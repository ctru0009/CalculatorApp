# CalculatorApp

This is a simple calculator service application using ASP.NET that can receive XML and/or JSON via HTTP POST and perform basic arithmetic operations (like addition, subtraction, multiplication, division and more can be added with minimal change to the code base).

## Features
- Supports both XML and JSON
- Supports multiple calculations in a single request
- Supports error handling
- Can be easily extended to support more operations with minimal changes

## Design
Overview: The application is designed to be simple and easy to understand. It uses a factory pattern to create the operation objects and a strategy pattern by implementing IOperation interface. The application is designed to be easily extensible by adding new operation classes that extend the OperationBase class and adding them to the OperationFactory class.

How to add a new operation:
1. Create a new class in Classes folder that extends the OperationBase class
1. Implement the Compute method
1. Add the new operation to the OperationFactory class
## Sample Request
JSON sample:
```json
{
  "maths": {
    "operation": [
      {
        "id": "add",
        "value": [
          "2",
          "3"
        ]
      }
    ]
  }
}
```

XML sample:
```
XML
<?xml version="1.0" encoding="UTF-8"?>
<Rootobject>
    <Maths>
        <Operation ID="add">
            <Value>2</Value>
            <Value>3</Value>
    </Maths>
</Rootobject>
```

## Sample Response
For 1 calculation:
```json
[5]
```
For 1 or more calculations:
```json
[5, 6, 7]
```

### Installation
1. Clone this repository
2. Open with Visual Studio
3. Run the application
4. Send POST requests via Swagger or Postman