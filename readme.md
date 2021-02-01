# Simple WebAPI CRUD (Students and Teachers Collections)
Author: Ahmed Saber Ahmed
email: ahmedsaber.1992@gmail.com

### API Docs

#### Student APIs
    - (GET) localhost:${activePort}/api/student #List all students
    - (GET) localhost:${activePort}/api/student/${Id} #get specific student info
    - (POST) localhost:${activePort}/api/student #create a new student
        expected request body {"firstname": "ahmed","lastname": "saber"}
    - (PUT) localhost:${activePort}/api/student #update existing student
        expected request body {"Id":0 ,"firstname": "ahmed","lastname": "saber"}
    - (DELETE) localhost:${activePort}/api/student/${Id} 

#### Teachers APIs
    - (GET) localhost:${activePort}/api/teacher #List all teachers
    - (GET) localhost:${activePort}/api/teacher/${Id} #get specific teacher info
    - (POST) localhost:${activePort}/api/teacher #create a new teacher
        expected request body {"firstname": "ahmed","lastname": "saber"}
    - (PUT) localhost:${activePort}/api/teacher #update existing teacher
        expected request body {"Id":0 ,"firstname": "ahmed","lastname": "saber"}
    - (DELETE) localhost:${activePort}/api/teacher/${Id} 

### For sql queries to add new entries and define tables
    - please create an sql db under the name `students_teachers`
    - please check the queies in file `sql_sample.sql` with the tables creating queries and sample data