import pandas as pd
from sqlalchemy import create_engine
from sqlalchemy.exc import SQLAlchemyError

user = ''
password = ''
db = ''

my_conn = create_engine(f"mysql+pymysql://{user}:{password}@localhost/{db}")

dfs = [pd.read_csv(str(i) + '.csv', header=None, sep='\t').iloc[:,:2] for i in range(4)]

dfs[0]['PROVINCE'] = 'Punjab'
dfs[1]['PROVINCE'] = 'Sindh'
dfs[2]['PROVINCE'] = 'Balochistan'
dfs[3]['PROVINCE'] = 'Khyber Pakhtunkhawa'

df = pd.concat(dfs)

records = df.to_records(index=False)

for i in range(len(records)):
    try:
        query = f"INSERT INTO  locations (DISTRICT ,PROVINCE)  VALUES('{records[i][0]}', '{records[i][2]}') "
        last_id_query = "SELECT LAST_INSERT_ID();"
        
        my_conn.execute(query)
        last_id = my_conn.execute(last_id_query).fetchone()[0]
        
        for j in range(records[i][1]):
            pa_query = f"INSERT INTO  pa_region (REGION ,LOC_ID)  VALUES({j+1}, {last_id}) "
            my_conn.execute(pa_query)
            
    except SQLAlchemyError as e:
        error = str(e.__dict__['orig'])
        print(error)
