# TestDataGenerator
A simple C# console application that generates random test user data and exports it to a CSV file using the `Bogus` and `CsvHelper` libraries.

## Features
- Generates realistic user data, including:
  - First name
  - Last name
  - Email
  - Phone number
  - Password
  - Address
  - Birth date
- Exports the generated data to a CSV file.
- Validates user input for record count.
- Customizable maximum record limit.

## Prerequisites
Make sure you have the following installed before running the project:

- [.NET SDK](https://dotnet.microsoft.com/download) (for running the application)
- [Git](https://git-scm.com/downloads) (for cloning the repository)

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/TestDataGenerator.git

2. Navigate to the project directory:
   cd TestDataGenerator

3. Run the application:
   dotnet run

## Example Output
Enter the number of records to generate: 100 
The test data was successfully generated and saved with 100 records in: test_users.csv

## Usage
After running the application, you'll be prompted to enter the number of records to generate.  
The generated test data will be saved in a file named `test_users.csv` in the project directory.

## Contributing
Contributions are welcome!  
If you'd like to contribute, please fork the repository and submit a pull request.
