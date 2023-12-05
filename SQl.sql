ALTER TABLE Attendance
ADD CONSTRAINT FK_Attendance_Classes_ClassID FOREIGN KEY (ClassID) REFERENCES Classes(ClassID);

-- Thêm khóa ngoại vào bảng Classes
ALTER TABLE Classes
ADD CONSTRAINT FK_Classes_Course FOREIGN KEY (CourseID) REFERENCES Courses(CourseID);
