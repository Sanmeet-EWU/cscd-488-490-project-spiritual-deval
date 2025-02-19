-- Create Database
CREATE DATABASE IF NOT EXISTS testdeval;

-- Use the created database
USE testdeval;

-- Create Events Table
CREATE TABLE Events (
    EventId INT PRIMARY KEY AUTO_INCREMENT,
    EventTitle VARCHAR(150) NOT NULL,
    EventDescription TEXT NOT NULL,
    EventDate DATETIME NOT NULL,
    EventLocation VARCHAR(150) NOT NULL,
    MaxParticipants INT NOT NULL,
    VolunteersRequired INT NOT NULL,
    SkillsRequired VARCHAR(255) NOT NULL
);

-- Create UserAccounts Table
CREATE TABLE UserAccounts (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    UserName VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(20) NOT NULL,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Email VARCHAR(100) NOT NULL
);

-- Create EventRegistrations Table
CREATE TABLE EventRegistrations (
    EventRegistrationId INT PRIMARY KEY AUTO_INCREMENT,
    UserId INT NOT NULL,
    EventId INT NOT NULL,
    RegistrationDate DATETIME NOT NULL,
    FOREIGN KEY (UserId) REFERENCES UserAccounts(Id),
    FOREIGN KEY (EventId) REFERENCES Events(EventId)
);

-- Create VolunteerRegistrations Table
CREATE TABLE VolunteerRegistrations (
    VolunteerRegistrationId INT PRIMARY KEY AUTO_INCREMENT,
    UserId INT NOT NULL,
    EventId INT NOT NULL,
    RegistrationDate DATETIME NOT NULL,
    SkillsProvided VARCHAR(255),
    FOREIGN KEY (UserId) REFERENCES UserAccounts(Id),
    FOREIGN KEY (EventId) REFERENCES Events(EventId)
);  

