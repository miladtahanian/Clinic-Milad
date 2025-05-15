-- ساخت دیتابیس کلینیک میلاد
CREATE DATABASE ClinicMilad;
GO

USE ClinicMilad;
GO

CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(20) NOT NULL -- 'مدیر', 'دکتر', 'پرستار'
);
GO

CREATE TABLE Patients (
    PatientID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    BirthDate DATE,
    PhoneNumber NVARCHAR(20),
    Address NVARCHAR(255)
);
GO

CREATE TABLE Prescriptions (
    PrescriptionID INT IDENTITY(1,1) PRIMARY KEY,
    PatientID INT FOREIGN KEY REFERENCES Patients(PatientID) ON DELETE CASCADE,
    DoctorID INT FOREIGN KEY REFERENCES Users(UserID) ON DELETE CASCADE,
    PrescriptionText NVARCHAR(MAX),
    DateCreated DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO Users (Username, Password, Role) VALUES (N'admin', N'1234', N'مدیر');
