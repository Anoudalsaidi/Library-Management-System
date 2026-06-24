# Library Management System

## Overview

The Library Management System is a console-based application designed to help a public library manage books, members, borrowing activities, reservations, and fines. The system allows registered community members to borrow and reserve books while enabling librarians to monitor library operations and generate useful reports.

## Features

### Member Management

* Register new library members.
* Store member information and membership records.
* Allow members to borrow and reserve books.

### Book Management

* Add new books to the library catalog.
* Store book details including:

  * Title
  * Author
  * Genre
  * Number of available copies
* Track book availability.

### Borrowing System

* Borrow available book copies.
* Record borrow date and due date.
* Set a fixed loan period of 14 days.
* Prevent borrowing when no copies are available.

### Return and Fine Calculation

* Return borrowed books.
* Automatically calculate overdue fines.
* Fine amount is based on the number of days past the due date.

### Reservation System

* Allow members to reserve books when all copies are currently borrowed.
* Notify members when a reserved book becomes available.

### Librarian Reports

* View all active loans.
* View overdue loans sorted by overdue days.
* Generate a report of the most borrowed books ranked by total borrow count.

## System Entities

### Book

* BookID
* Title
* Author
* Genre
* TotalCopies
* AvailableCopies
* BorrowCount

### Member

* MemberID
* FullName
* Email
* PhoneNumber

### Loan

* LoanID
* BorrowDate
* DueDate
* ReturnDate
* FineAmount
* MemberID
* BookID

### Reservation

* ReservationID
* ReservationDate
* Status
* MemberID
* BookID

## Business Rules

1. A member must be registered before borrowing books.
2. A book can only be borrowed if at least one copy is available.
3. The borrowing period is 14 days.
4. Late returns generate fines based on overdue days.
5. Reservations are only allowed when all copies of a book are borrowed.
6. Returning a book increases the number of available copies.
7. Borrow count is updated whenever a book is borrowed.
8. Overdue loans are displayed in descending order of overdue days.

## Expected Outputs

* List of registered members.
* List of books and availability status.
* Active loan report.
* Overdue loan report.
* Reservation list.
* Most borrowed books report.
* Fine calculation summary.

## Technologies Used

* C#
* .NET
* Entity Framework Core
* SQL Server

## Project Goal

The main goal of this project is to automate library operations, improve book tracking, manage borrowing activities efficiently, and provide librarians with accurate reports for decision-making.
