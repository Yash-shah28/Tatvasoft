CREATE TABLE  students (
	student_id serial  PRIMARY KEY,
	name character varying(100) NOT NULL,
	age integer NOT NULL,
	email character varying(100) NOT NULL
)

CREATE TABLE courses (
    course_id SERIAL PRIMARY KEY,
    student_id INT REFERENCES students(student_id),
    course_name VARCHAR(100),
    grade CHAR(2)
);

INSERT INTO students (name, age, email)
VALUES ('Amit Sharma', 20, 'amit@example.com');


INSERT INTO courses (student_id, course_name, grade)
VALUES (1, 'Mathematics', 'A');

INSERT INTO students (name, age, email)
VALUES
    ('Amit Sharma', 20, 'amit@example.com'),
    ('Priya Verma', 21, 'priya@example.com'),
    ('Rahul Mehra', 22, 'rahul@example.com'),
    ('Sneha Rao', 19, 'sneha@example.com'),
    ('Karan Kapoor', 23, 'karan@example.com');


INSERT INTO courses (student_id, course_name, grade)
VALUES
    (1, 'Mathematics', 'A'),
    (1, 'Physics', 'B'),
    (2, 'Chemistry', 'A'),
    (3, 'Biology', 'C'),
    (4, 'English', 'B'),
    (5, 'Computer Science', 'A'),
    (3, 'History', 'B'),
    (2, 'Economics', 'B');

SELECT * FROM students;

SELECT * FROM courses;

UPDATE students
SET age = 21
WHERE student_id = 1;

UPDATE courses
SET grade = 'B'
WHERE course_id = 1;


DELETE FROM courses WHERE course_id = 1;
DELETE FROM students WHERE student_id = 1;

SELECT 
	s.name,
	c.course_name,
	c.grade
From 
	students as s
INNER JOIN
	    courses as c ON s.student_id = c.student_id;


SELECT 
    student_id, 
    COUNT(*) AS total_courses
FROM 
    courses
GROUP BY 
    student_id;


SELECT 
    student_id,
    MAX(grade) AS highest_grade
FROM 
    courses
GROUP BY 
    student_id;

SELECT name FROM students
WHERE student_id IN (
    SELECT student_id FROM courses WHERE grade = 'A'
);

SELECT * FROM students
ORDER BY age DESC;

