-- Sample Data for Events Table
INSERT INTO Events (EventTitle, EventDescription, EventDate, EventLocation, MaxParticipants, VolunteersRequired, SkillsRequired)
VALUES 
('Yoga Session', 'A relaxing yoga session for the community.', '2025-03-01 09:00:00', 'Community Center', 50, 5, 'Yoga, Relaxation'),
('Cooking Class', 'A hands-on cooking class with a focus on healthy eating.', '2025-03-05 14:00:00', 'Cooking School', 30, 3, 'Cooking, Food Safety');

-- Sample Data for UserAccounts Table
INSERT INTO UserAccounts (UserName, Password, Role, FirstName, LastName, Email)
VALUES 
('john_doe', 'password123', 'User', 'John', 'Doe', 'john.doe@example.com'),
('jane_smith', 'password456', 'Administrator', 'Jane', 'Smith', 'jane.smith@example.com'),
('mark_jones', 'password789', 'User', 'Mark', 'Jones', 'mark.jones@example.com');

-- Sample Data for EventRegistrations Table
INSERT INTO EventRegistrations (UserId, EventId, RegistrationDate)
VALUES 
(1, 1, '2025-02-10 10:00:00'),
(3, 2, '2025-02-10 11:00:00');

-- Sample Data for VolunteerRegistrations Table
INSERT INTO VolunteerRegistrations (UserId, EventId, RegistrationDate, SkillsProvided)
VALUES 
(1, 1, '2025-02-10 10:00:00', 'Yoga Instruction'),
(2, 2, '2025-02-10 11:00:00', 'Cooking Expert');

