import mysql.connector

dbConnection = mysql.connector.connect(
host="bwab9tff3zf362aatm9r-mysql.services.clever-cloud.com",
user="ubxnqlqaw2c8zjt4",
passwd="0dOdA4pjm7O6Jk4mj2v4",
database="bwab9tff3zf362aatm9r"
)

db_cursor = dbConnection.cursor()
db_cursor.execute("DELETE FROM students WHERE id= 148")
dbConnection.commit()
db_cursor.execute("SELECT id, name , age FROM students")
allData = db_cursor.fetchall()

for db in allData:
    print(db)