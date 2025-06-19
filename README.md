# GADCourse - Metro Library Management System

## 1. Project Title and Description

This project implements a basic library management system using C# and the .NET Framework with MetroFramework for the user interface. It allows for managing book details, member information, borrowing history, and staff details.  The system uses a SQLite database for data persistence.

## 2. Features and Functionality

The Metro Library Management System includes the following features:

*   **Book Details Management:** Add, edit, and view book information (Book ID, Title, Author, Publication Year, ISBN, Available Count).  Accessed via `Form1` -> "Book Details" tile.
*   **Member Details Management:** Add, edit, view, and delete member information (NIC, Name, Address, Phone Number, Email, Member Type, Registration Date). Includes search and filtering functionalities. Accessed via `Form1` -> "Member Details and Registration" tile.
*   **Borrowing Management:**  Record book borrowing transactions (Borrowing ID, Member NIC, Book ID, Borrow Date, Return Date). Accessed via `Form1` -> "Borrowing" tile.
*   **Hand Over Management:** Placeholder form for managing returning process. Accessed via `Form1` -> "Hand Over" tile.
*   **Staff Login:**  Authentication for staff members to access the system.
*   **Staff Details Management:**  Add, edit, view, and delete staff information (NIC, Name, Address, Phone Number, Email, Staff Type, Registration Date, Password). Includes password management and staff authentication. Accessed via `Form1` -> "Staff Details and Registration" tile.
*   **Forget Password Recovery:** (Unimplemented)  A placeholder form suggesting email password recovery.

## 3. Technology Stack

*   **Programming Language:** C#
*   **Framework:** .NET Framework (Windows Forms)
*   **UI Library:** MetroFramework
*   **Database:** SQLite

## 4. Prerequisites

Before running the application, ensure the following prerequisites are installed:

*   .NET Framework (version is not specified in source code, but likely 4.5 or higher)
*   SQLite ADO.NET provider.  This is typically handled by NuGet package restoration.

## 5. Installation Instructions

1.  **Clone the Repository:**

    ```bash
    git clone https://github.com/billodi/GADCourse.git
    ```

2.  **Open the Project in Visual Studio:**
    *   Navigate to the cloned directory.
    *   Open the `MetroLibrary.sln` file in Visual Studio.

3.  **Restore NuGet Packages:**
    *   In Visual Studio, go to `Tools` -> `NuGet Package Manager` -> `Restore NuGet Packages`.  This will download and install the necessary dependencies, including MetroFramework and the SQLite provider.

4.  **Build the Solution:**
    *   In Visual Studio, go to `Build` -> `Build Solution`.

## 6. Usage Guide

1.  **Running the Application:**

    *   After building the solution successfully, run the application from Visual Studio by pressing `F5` or clicking the `Start` button.

2.  **Staff Login:**

    *   The application starts by displaying the member details (`MemberDetails` form directly).
    *   To utilize staff features (delete/update members), authentication is required using the authentication forms.

3.  **Navigating the Application:**

    *   The `Form1` acts as the dashboard, providing access to the main functionalities through Metro Tiles.
    *   Click on the tiles to open the respective forms.

4.  **Database:**

    *   The SQLite database file (`database.db`) is created automatically in the application's execution directory if it doesn't exist.

## 7. API Documentation (Not Applicable)

This project does not expose a public API.

## 8. Contributing Guidelines

1.  **Fork the Repository:**
    *   Create your own fork of the repository on GitHub.

2.  **Create a Branch:**
    *   Create a new branch for your feature or bug fix:

    ```bash
    git checkout -b feature/your-feature-name
    ```

3.  **Make Changes:**
    *   Implement your changes, adhering to the project's coding style and conventions.
    *   Add comments and documentation as necessary.

4.  **Commit Changes:**
    *   Commit your changes with a descriptive commit message:

    ```bash
    git commit -m "Add: Implement new feature"
    ```

5.  **Push Changes:**
    *   Push your changes to your forked repository:

    ```bash
    git push origin feature/your-feature-name
    ```

6.  **Create a Pull Request:**
    *   Submit a pull request from your branch to the `master` branch of the original repository.
    *   Provide a clear and concise description of your changes in the pull request.

## 9. License Information

No license is specified in the repository.  All rights are reserved unless explicitly stated otherwise.

## 10. Contact/Support Information

For questions or support, please contact:

*   billodi (via GitHub)