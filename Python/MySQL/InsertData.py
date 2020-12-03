import mysql.connector

dbConnection = mysql.connector.connect(
host="localhost",
user="root",
passwd="toor",
database="aa"
)

dataType = "INSERT INTO students(id , name , age ,attend , hobby)values(null, %s ,%s ,%s ,%s);"
data = [("HanZaw",20,3,"Coder"),("ZeroOne",20,3,"C,C++")]
dbCursor=dbConnection.cursor()
dbCursor.executemany(dataType,data)
#dbConnection.commit()
dbConnection.commit()
print("Data are inserted")
print(dbCursor.rowcount)
dbCursor.execute("SELECT * FROM aa.students;")

for d in dbCursor:
    print(d)
