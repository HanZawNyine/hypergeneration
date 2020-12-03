import mysql.connector

dbConnection = mysql.connector.connect(
host="bwab9tff3zf362aatm9r-mysql.services.clever-cloud.com",
user="ubxnqlqaw2c8zjt4",
passwd="0dOdA4pjm7O6Jk4mj2v4",
database="bwab9tff3zf362aatm9r"
)

db_cursor = dbConnection.cursor()

db_cursor.execute("SHOW DATABASES")


for tb in db_cursor:
    print(tb)