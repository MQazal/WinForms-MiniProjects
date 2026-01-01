# WinForms-MiniProjects
This repo represents my beginnings in the world of C# Windows Forms programming and demonstrating basic desktop app concepts through simple projects.

<br>Project#1: Pizza Order:
<br>A customizable pizza-ordering application with these features:</br>
<ul>
  <li>Menus serve the user</li>
  <li>Dynamic price calculation</li>
  <li>Category-based toppings</li>
  <li>Clean user interface</li>
</ul>
https://github.com/user-attachments/assets/59422b43-979c-4744-8e4b-12c2d78ab055
</br>


<br>Project#2: Tic-Tac-Toe Game:
<br>A colorful and interactive game with these features:</br>
<ul>
  <li>Player-vs-Player gameplay</li>
  <li>Clear visual grid with dynamic updates</li>
  <li>Turn indicator (Player 1 / Player 2)</li>
  <li>Automatic winner detection</li>
  <li>Restart button to reset the board</li>
  <li>Neon-styled UI for a modern appearance</li>
</ul>
https://github.com/user-attachments/assets/ca3d7876-2108-4d5f-8349-afb4b93545e8
</br>


<br>Project#3: Tree View To-Do App:</br>
<br>
A task management desktop application that organizes tasks hierarchically using a TreeView control, with the following features:
</br>
<ul>
  <li>Hierarchical task organization (Parent / Child tasks)</li>
  <li>Add, edit, and delete tasks dynamically</li>
  <li>Visual task grouping using TreeView nodes</li>
  <li>Simple and user-friendly interface</li>
  <li>Supports task status management</li>
</ul>


<br>Project#4: To-Do List (ListView Control):</br>
<br>
A desktop task management application built using the ListView control to display and manage tasks efficiently, with the following features:
</br>
<ul>
  <li>Task display using ListView rows and columns</li>
  <li>Add, edit, and remove tasks dynamically</li>
  <li>Organized task details (title, status, priority, etc.)</li>
  <li>Supports task selection and updates</li>
  <li>Clean and structured user interface</li>
</ul>


<br>Project#5: String Encryptor:</br>
<br>
A desktop application designed to encrypt and decrypt text strings using simple encryption techniques, with the following features:
</br>
<ul>
  <li>Text encryption and decryption functionality</li>
  <li>User input handling for plain and encrypted strings</li>
  <li>Supports basic encryption algorithms</li>
  <li>Instant result display</li>
  <li>Simple and intuitive user interface</li>
</ul>


<br>Project#6: Employee Management System</br>
<br>
A comprehensive desktop application designed to manage employee records with full CRUD operations, featuring an advanced Windows Forms interface with the following capabilities:
</br>
<h3>Core Features</h3>
<h4>Employee Management</h4>
<ul>
  <li><strong>Add New Employee:</strong> Complete form with validation for all employee details including personal information, job details, work hours, and contact information</li>
  <li><strong>View Employee:</strong> Display detailed employee information with visual representation</li>
  <li><strong>Update Employee:</strong> Modify existing employee records with data persistence</li>
  <li><strong>Delete Employee:</strong> Remove employee records with confirmation dialogs</li>
  <li><strong>Search Employee:</strong> Quick lookup by employee ID</li>
  <li><strong>Clear List:</strong> Bulk deletion of all employee records</li>
</ul>
<h4>Data Management</h4>
<ul>
  <li><strong>File-based Storage:</strong> Persistent data storage using text files with custom delimiter (#//#)</li>
  <li><strong>Auto-load:</strong> Automatically loads employee data from file on startup</li>
  <li><strong>Data Synchronization:</strong> Real-time sync between UI and file storage</li>
  <li><strong>ListView Integration:</strong> Visual display of all employees in a sortable, multi-column list</li>
</ul>
<h4>User Interface Features</h4>
<ul>
  <li><strong>Login System:</strong> Secure authentication with username/password validation</li>
  <li><strong>Dynamic Image Display:</strong> Gender-specific employee icons (male/female)</li>
  <li><strong>Real-time Clock:</strong> Live time and date display on management screen</li>
  <li><strong>Menu Strip Navigation:</strong> Easy access to all features through organized menu system</li>
  <li><strong>Form Validation:</strong> Comprehensive error handling with ErrorProvider component</li>
  <li><strong>Responsive Design:</strong> Multiple grouped input sections for organized data entry</li>
</ul>
<h4>Employee Data Fields</h4>
<ul>
  <li>Employee ID (2 digits)</li>
  <li>First Name and Last Name</li>
  <li>Age (25-65 validation)</li>
  <li>Date of Birth</li>
  <li>Job Title</li>
  <li>Department</li>
  <li>Salary (SAR currency)</li>
  <li>Hiring Date</li>
  <li>Gender (Male/Female with radio buttons)</li>
  <li>Work Hours (From/To with AM/PM)</li>
  <li>Phone Number (Saudi format: +966)</li>
  <li>Email Address</li>
</ul>
<h4>Technical Features</h4>
<ul>
  <li><strong>Input Validation:</strong> MaskedTextBox for formatted inputs (ID, age, salary, phone, time)</li>
  <li><strong>Date Pickers:</strong> DateTimePicker controls for date selection</li>
  <li><strong>ComboBox Selection:</strong> Dropdown menus for job titles and departments</li>
  <li><strong>Tab Index Management:</strong> Logical form navigation flow</li>
  <li><strong>Error Provider:</strong> Visual validation feedback</li>
  <li><strong>Image List:</strong> Organized image resources for UI elements</li>
  <li><strong>Structure-based Data:</strong> Uses stEmployeeInfo struct for type-safe data handling</li>
  <li><strong>List Collections:</strong> Generic List&lt;T&gt; for in-memory data manipulation</li>
</ul>
<h4>Security & UX</h4>
<ul>
  <li>Logout functionality to return to login screen</li>
  <li>Confirmation dialogs for destructive operations</li>
  <li>Read-only fields where appropriate</li>
  <li>Clear visual feedback for all operations</li>
  <li>Multiple themed form designs (login, management, add, update, show, search)</li>
</ul>

<br>
This enterprise-level application demonstrates advanced Windows Forms development with proper separation of concerns, data persistence, and professional UI/UX design patterns.
</br>


<br>Project#7: Computer Science Memory Game</br>
<br>A desktop memory matching game built with Windows Forms, featuring computer science-themed images and multiple difficulty levels. The game challenges players
to match pairs of cards within a time limit.
</br>

🎮 Features
🧠 Core Gameplay

26 Interactive Cards
Grid layout with 13 matching pairs of computer science icons.

Image Matching Logic
Click two cards to reveal and match identical images.

Smart Card Management
Uses ImageList control for efficient image storage and retrieval.

Index-Based Tracking
Hidden image indices are stored in Button Tag properties for fast comparison.

🎮 Game Controls
⏱️ Difficulty Levels

Easy — 10 minutes

Medium — 3 minutes

Hard — 2 minutes

Real-time Timer
Countdown timer with MM:SS display.

Pause / Continue
Suspend and resume gameplay at any time.

Restart Function
Reset the game with a fresh card shuffle.

Sound Toggle
Enable or disable click sound effects.

🎨 Visual Elements

Dynamic Card Reveal
Smooth transition between question mark and hidden images.

Card State Management
Tracks revealed, matched, and hidden cards.

Score Display
Real-time score counter (13 matches required to win).

Custom Background
Themed UI with computer science–related imagery.

🛠️ Technical Implementation

Fisher–Yates Shuffle Algorithm
Ensures random card distribution each game.

Delay Timer
1-second reveal delay for non-matching pairs.

State Machine
Proper game state handling (Running, Paused, Finished).

Event-Driven Architecture
Button click handlers with validation logic.

Error Handling
Prevents duplicate clicks and invalid moves.


🖼️ Card Themes
<p>The game includes 13 computer science themed images:</p>

<strong>AI & Machine Learning</strong>
<strong>Cybersecurity</strong> (Virus, Hack)
<strong>Networking & IoT</strong>
<strong>Programming Languages</strong> (C#, C++)
<strong>Databases & Data Structures</strong>
<strong>Operating Systems</strong>
<strong>Mobile & Desktop Applications</strong>
<strong>Console Development</strong>


🏗️ Architecture
Key Components

ImageList Control: Stores all game images with index-based access
Button Array: 26 buttons ordered by TabIndex for consistent layout
Timer Controls:

<code>GameLevelTimer</code>: Main countdown (1000ms interval)
<code>DelayTimer</code>: Card flip delay (1000ms interval)

State Variables: Tracks selected buttons, score, and game status

Data Flow
<ol>
  <li>Images loaded into ImageList at startup</li>
  <li>Index list created and shuffled (Fisher-Yates)</li>
  <li>Shuffled indices assigned to button Tags</li>
  <li>Click events reveal images by fetching from ImageList using stored index</li>
  <li>Comparison logic checks Tag values (integer indices)</li>
  <li>Match processing disables buttons or flips them back</li>
</ol>
Game Logic Pattern
Click Button → Validate Click → Reveal Image → Store in Temp
→ Compare Tags → Match? → Yes: Disable & Score | No: Delay Flip Back

🎯 Win/Lose Conditions
Win: Match all 13 pairs (Score = 13)
Lose: Timer reaches 0:00 before all matches found

🔧 Technical Highlights
<ul>
  <li>Clean separation of concerns with focused methods</li>
  <li>Enum-based state management (<code>enLevel</code>, <code>enGameOver</code>)</li>
  <li>Efficient image storage using integer indices vs. Image objects</li>
  <li>Proper resource management with ImageList</li>
  <li>Input validation and error prevention</li>
  <li>Smooth UX with timed animations</li>
</ul>

📋 Prerequisites
<strong>.NET Framework</strong> (Windows Forms Application)
<strong>Windows OS</strong>
<strong>Computer Science themed image resources</strong>
