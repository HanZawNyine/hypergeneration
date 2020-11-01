import pymongo

connection = pymongo.MongoClient("localhost",27017)
database = connection["my_db1"]
collection=database["my_col2"]

try:
    collection.drop()
    print("Collection {} is droped".format(collection))    
except Exception as error:
    print(error)
