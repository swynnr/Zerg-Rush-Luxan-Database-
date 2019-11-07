import sys
import MySQLdb as sql


def connection():
    # db connection
    connStr = "leia.cs.spu.edu"
    userStr = "tangc4"
    passStr = "tangc45$4410X"
    db = "employees"
    conn = sql.connect(connStr, userStr, passStr, db)

    # query
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
    connection()


if __name__ == "__main__":
    main()

