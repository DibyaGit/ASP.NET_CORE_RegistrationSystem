# User Registration and Validation System

## Project Overview
This application is a registration system for an online platform designed to ensure data integrity and provide clear user feedback. It demonstrates the implementation of server-side and client-side validation using Data Annotations in an ASP.NET Core Razor Pages environment.

## Features
* **User Registration Form**: Includes essential fields for Username, Email, Password, and Confirm Password.
* **Input Validation**:
    * **Required Fields**: Ensures all mandatory information is provided.
    * **Email Format**: Verifies that the email follows proper standard formatting.
    * **Password Strength**: Enforces specific length constraints for passwords.
    * **Password Matching**: Uses custom validation to ensure the Password and Confirm Password fields are identical.
* **Dual-Layer Validation**:
    * **Client-Side**: Uses JavaScript libraries to provide instant feedback and enforce rules in the browser before submission.
    * **Server-Side**: Re-validates data in the model to ensure security and data integrity.
* **Error Reporting**: Displays a validation summary and individual messages for each field to guide the user.

## Project Structure
* **Models/UserRegistration.cs**: Contains the data properties and validation logic using Data Annotations.
* **Pages/Register.cshtml**: The front-end Razor Page that renders the form and error messages.
* **Pages/Register.cshtml.cs**: The back-end logic that processes submissions and checks the model state.

## Technical Requirements
* Visual Studio
* .NET Core (C#)
* ASP.NET Core Razor Pages

## How to Run
1. Open the project solution in Visual Studio.
2. Press **F5** to build and run the application.
3. Navigate to `/Register` in your web browser to test the validation system.
