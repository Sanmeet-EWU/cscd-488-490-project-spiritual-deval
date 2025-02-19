---
Overview

This repository contains the database schema for project Spiritual Deval designed to manage events, user accounts, event registrations, and volunteer registrations. The schema is implemented using MySQL Workbench, chosen for its open source nature, ease of use, and compatibility with the project's requirements. This README provides an overview of the database design, key decisions, challenges, and planned improvements.

---

Database Schema

Tables

1. Events
   - EventId (Primary Key, int): Unique identifier for each event.
   - EventTitle (varchar(150)): Title of the event.
   - EventDescription (text): Detailed description of the event.
   - EventDate (datetime): Date and time of the event.
   - EventLocation (varchar(150)): Location of the event.
   - MaxParticipants (int): Maximum number of participants allowed.
   - VolunteersRequired (int): Number of volunteers required for the event.
   - SkillsRequired (varchar(255)): Skills needed for the event.

2. UserAccounts
   - Id (Primary Key, int): Unique identifier for each user.
   - UserName (varchar(100)): Username for authentication.
   - Password (varchar(100)): Hashed password for security.
   - Role (varchar(20)): User role (e.g., administrator, regular user).
   - FirstName (varchar(100)): User's first name.
   - LastName (varchar(100)): User's last name.
   - Email (varchar(100)): User's email address.

3. EventRegistrations
   - EventRegistrationId (Primary Key, int): Unique identifier for each event registration.
   - UserId (Foreign Key, int): References Id in UserAccounts.
   - EventId (Foreign Key, int): References EventId in Events.
   - RegistrationDate (datetime): Date and time of registration.

4. VolunteerRegistrations
   - VolunteerRegistrationId (Primary Key, int): Unique identifier for each volunteer registration.
   - UserId (Foreign Key, int): References Id in UserAccounts.
   - EventId (Foreign Key, int): References EventId in Events.
   - RegistrationDate (datetime): Date and time of volunteer registration.
   - SkillsProvided (varchar(255)): Skills provided by the volunteer.

---

Relationships

- Events and EventRegistrations: A one-to-many relationship where an event can have multiple registrations.
- UserAccounts and EventRegistrations: A one-to-many relationship where a user can register for multiple events.
- Events and VolunteerRegistrations: A one-to-many relationship where an event can have multiple volunteer registrations.
- UserAccounts and VolunteerRegistrations: A one-to-many relationship where a user can volunteer for multiple events.

---

Database Justification

Why MySQL Workbench?

- Open Source: MySQL Workbench is free to use, aligning with the project's budget constraints.
- Ease of Use: The team has prior experience with MySQL Workbench, reducing the learning curve.
- Compatibility: MySQL integrates well with the Blazor framework, which is used for the front-end implementation.
- Scalability: MySQL is capable of handling the project's current and future data requirements.

---

Key Design Decisions

Normalization

The database schema is normalized to Third Normal Form to eliminate redundancy and ensure data integrity. Key normalization steps include:
- Separating user details, event details, and registrations into distinct tables.
- Using foreign keys to establish relationships between tables.

Indexing

- Primary keys are indexed by default in MySQL.

---

Challenges

1. Scalability: As the number of users and events grows, the database may require optimization. 

---

Planned Improvements

1. Addition of image storing: To improve the presentation of event pages, the option to add an image to each event record is planned to be added to the Events table.

---

Conclusion

This database schema provides a solid foundation for managing events, user accounts, and volunteer registrations. By leveraging MySQL Workbench, the schema is designed to be scalable, secure, and easy to maintain. Future improvements will focus on enhancing performance and the addition of images for events.
