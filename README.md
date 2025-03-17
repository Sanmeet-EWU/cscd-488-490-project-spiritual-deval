# SpiritualDevalApp

## Spiritual Deval: Live Demo
[Watch the live demo on YouTube](https://www.youtube.com/watch?v=5KyD68xe5zs)

## Overview

SpiritualDevalApp is a web application designed to improve communication, event management, and volunteering for spiritual temples. The app allows users to register for events, volunteer, and stay updated on temple activities. It also provides an admin panel for managing users, events, and volunteer updates.

## Installation

### Prerequisites
- .NET 8.0
- MySQL Server
- Visual Studio Code

### Steps
1. **Clone the repository**
   ```bash
   git clone https://github.com/Sanmeet-EWU/cscd-488-490-project-spiritual-deval.git
   cd SpiritualDevalApp
   ```

2. **Configure the database**
   - Update the connection string in `appsettings.json` to match your MySQL setup.

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Access the app**
   - Open a browser and go to `http://localhost:5164` (or the port Blazor assigns).

---

## Usage Details

### General Users
- **Homepage**: View upcoming events and register or volunteer.
- **Event Page**: Shows event details and allows registration or volunteering.
- **Volunteering**: Click **Volunteer → Subscribe for updates** to receive volunteer notifications.
- **About Page**: Provides information about the temple.
- **Donation Page**: Placeholder for future donation functionality.
- **Volunteer Page**: Explains how users can get involved.
- **Account Creation**: Click **Get In Touch → Create an account** (required for event registration/volunteering).

### Admin Users
- **Admin Dashboard**: View registered users and volunteers.
- **Create Events**: Click **Create Event**, fill out details, and submit. The event will appear on the homepage.
- **Promote Users**: Click **Promote User to Admin**, enter the user’s email to grant admin privileges.
- **Send Volunteer Updates**: Click **Send Volunteer Update**, enter a title and message, and send emails to all subscribed volunteers.

### Authentication
- **New Users**: Sign up via the Login Page (“Don’t have an account? Create one.”).
- **Existing Users**: Log in with your credentials.
- **First Admin**: The first registered user is assigned admin privileges automatically.
