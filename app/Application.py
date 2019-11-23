import sys
import mysql.connector
from mysql.connector import Error
from Queries import Queries


def connection():
    # db connection
    conn = None
    connStr = "leia.cs.spu.edu"
    userStr = "tangc4"
    passStr = "tangc45$4410X"
    db = "employees"
    conn = mysql.connector.connect(
        host="leia.cs.spu.edu",
        database="employees",
        user="tangc4",
        password="tangc45$4410X",
    )

    # query
    if conn.is_connected():
        print("Connected to Database")

    curs = conn.cursor()
    curs.execute("select * from employees limit 10")

    while True:
        row = curs.fetchone()
        if row == None:
            break
        print(row)
    # row = curs.fetchall()          //These do the same thing except all at once vs row by row
    # print(row)


def main():
    test = Queries()
    testing = test.test()
    print(testing)
    # connection()


if __name__ == "__main__":
    main()
