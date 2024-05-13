--Create tables

CREATE TABLE Students (
    UniqueNumber VARCHAR(20) PRIMARY KEY,
    Name VARCHAR(255),
    FinalGrade DECIMAL(5,2)
);


CREATE TABLE Questions (
    QuestionID INT PRIMARY KEY,
    QuestionText VARCHAR(250)
);


CREATE TABLE Answers (
    AnswerID INT PRIMARY KEY,
    AnswerText VARCHAR(250),
    QuestionID INT,
    Score INT,
    FOREIGN KEY (QuestionID) REFERENCES Questions(QuestionID) ON DELETE CASCADE
);


--Insert data

INSERT INTO Students (UniqueNumber, Name) VALUES
('S001', 'ivan'),
('S002', 'jose');

INSERT INTO Questions (QuestionID, QuestionText) VALUES
(1, 'What does HTML stand for?'),
(2, 'Which language runs in a web browser?'),
(3, 'What is used to style web pages?'),
(4, 'Which SQL statement is used to extract data from a database?'),
(5, 'What is the correct syntax to output "Hello World" in Python?');


INSERT INTO Answers (AnswerID, AnswerText, QuestionID, Score) VALUES
(1, 'HyperText Markup Language', 1, 20),
(2, 'Hyperlinks and Text Markup Language', 1, 0),
(3, 'Home Tool Markup Language', 1, 0),

(4, 'JavaScript', 2, 20),
(5, 'Java', 2, 0),
(6, 'C++', 2, 0),

(7, 'CSS', 3, 20),
(8, 'Python', 3, 0),
(9, 'PHP', 3, 0),

(10, 'SELECT', 4, 20),
(11, 'CREATE', 4, 0),
(12, 'DELETE', 4, 0),

(13, 'print("Hello World")', 5, 20),
(14, 'echo "Hello World"', 5, 0),
(15, 'Console.WriteLine("Hello World")', 5, 0);
