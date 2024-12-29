# Bank Management System  

This project is a **Bank Management System** implemented in C#. It simulates a simple banking system with essential functionalities such as account creation, deposit, withdrawal, and displaying account details.  

## Features  
1. **Open New Account**:  
   - Allows users to create a new account by providing their name and age.  
   - Generates a random account number.  
   - Ensures only users aged 18 or above can open an account.  

2. **Deposit Money**:  
   - Enables users to deposit money into their account by entering the correct account number.  

3. **Withdraw Money**:  
   - Allows users to withdraw money from their account if sufficient funds are available.  

4. **Show Account Details**:  
   - Displays account information such as the account holder's name, age, account number, and current balance.  

5. **Error Handling**:  
   - Verifies the account number for transactions to ensure security.  

## How It Works  
1. **Account Creation**:  
   - The user provides their name and age.  
   - A unique account number is generated randomly.  
   - If the age is less than 18, the system prevents account creation.  

2. **Transactions**:  
   - The system validates the entered account number before processing deposits or withdrawals.  
   - Updates the account balance accordingly.  

3. **Account Display**:  
   - Users can view their account details by entering the correct account number.  

## Prerequisites  
- Visual Studio (or any C# IDE).  
- .NET Framework installed on your system.  

## How to Run  
1. Clone this repository to your local machine.  
2. Open the project in Visual Studio or your preferred IDE.  
3. Build and run the program.  
4. Follow the prompts in the console to perform various banking operations.  

## Code Overview  
- **Namespace**: `CsharpLearning`.  
- **Class**: `BankManagementSystem`.  
- **Methods**:  
  - `OpenAccount()`: For creating new accounts.  
  - `Deposit()`: For depositing money into an account.  
  - `Withdraw()`: For withdrawing money from an account.  
  - `ShowAccount()`: For displaying account details.  

## Example Interaction  
```plaintext
Please Select Your Query!  
1.Open New Account  
2.Deposit Money  
3.Withdraw Money  
4.Show Account Detail  
5.Terminate Transaction  
Enter Your Query Choice: 1  

Enter Your Account holder's name: John Doe  
Enter the Age of Account Holder: 25  
Your Account is Successfully Created:  
Account Holder      : John Doe  
Account Holder Age  : 25  
Account Number      : 123456789  
