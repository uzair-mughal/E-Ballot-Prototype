#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Tue Dec  8 19:05:30 2020

@author: muzammil
"""

import pandas as pd
from sqlalchemy import create_engine
from sqlalchemy.exc import SQLAlchemyError

my_conn = create_engine("mysql+pymysql://muzz:X4uhhrdoncj-@localhost/sample_db")


dfs = [pd.read_csv(str(i) + '.csv', header=None, sep='\t').iloc[:,:2] for i in range(4)]

dfs[0]['PROVINCE'] = 'Punjab'
dfs[1]['PROVINCE'] = 'Sindh'
dfs[2]['PROVINCE'] = 'Balochistan'
dfs[3]['PROVINCE'] = 'Khyber Pakhtunkhawa'

na_seats = [141, 61, 16, 51]

for k, df in enumerate(dfs):
    df.columns = ['DISTRICT', 'PA_SEATS', 'PROVINCE']
    df['NA_SEAT'] = (df['PA_SEATS'] / sum(df['PA_SEATS'])) * na_seats[k]
    df['NA_SEAT'] = df['NA_SEAT'].round()
    df['NA_SEAT'] = df['NA_SEAT'].apply(lambda x: x if x > 0 else 1).astype('int32')
    
df = pd.concat(dfs)
df.iloc[:, 1] = df.iloc[:, -1]
df = df.drop(['NA_SEAT'], axis=1)
df.columns = [0, 1, 'PROVINCE']

records = df.to_records(index=False)

for i in range(len(records)):
    try:        
        query = f"INSERT INTO locations (DISTRICT ,PROVINCE) VALUES ('{records[i][0]}', '{records[i][2]}') ON DUPLICATE KEY UPDATE LOC_ID = LAST_INSERT_ID(LOC_ID), DISTRICT = '{records[i][0]}', PROVINCE = '{records[i][2]}'";
        last_id_query = "SELECT LAST_INSERT_ID();"
        
        query = my_conn.execute(query)
        last_id = my_conn.execute(last_id_query).fetchone()[0]
        
        for j in range(records[i][1]):
            pa_query = f"INSERT INTO  na_region (REGION ,LOC_ID)  VALUES({j+1}, {last_id})"
            my_conn.execute(pa_query)
            
    except SQLAlchemyError as e:
        error = str(e.__dict__['orig'])
        print(error)