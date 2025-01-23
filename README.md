# Test Data Generator

This project generates test user data and exports it to CSV or Excel files.

## Features

- Generates random user data including:
  - First Name
  - Last Name
  - Email
  - Phone Number
  - Address
  - Password
  - Birth Date
- Supports export to:
  - CSV (`.csv`)
  - Excel (`.xlsx`)

## Requirements

Ensure the following NuGet packages are installed:
- [Bogus](https://www.nuget.org/packages/Bogus) - For generating fake data
- [CsvHelper](https://www.nuget.org/packages/CsvHelper) - For exporting to CSV
- [EPPlus](https://www.nuget.org/packages/EPPlus) - For exporting to Excel

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/TestDataGenerator.git
   ```

2. Navigate to the project directory: 
   ```bash
   cd TestDataGenerator
   ```

3. Install required dependencies:
   ```bash
   dotnet add package Bogus
   dotnet add package CsvHelper
   dotnet add package EPPlus --version 6.0.8
   ```

4. Run the application: 
   ```bash
   dotnet run
   ```

## Example Output

### CSV Output
```
Enter the number of records to generate: 100
Enter the file format (csv/excel): csv
The test data was successfully generated and saved with 100 records in: test_users.csv
```

### Excel Output
```
Enter the number of records to generate: 50
Enter the file format (csv/excel): excel
The test data was successfully generated and saved with 50 records in: test_users.xlsx
```

## Usage

After running the application:
1. Enter the number of records to generate
2. Choose the file format (CSV or Excel)
3. The data will be saved in the project directory

## Contributing

Contributions are welcome! If you'd like to contribute, please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License.
