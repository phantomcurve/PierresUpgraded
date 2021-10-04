# Pierre's Bakery Vendor Order Tracker

#### Vendor order tracker for Pierre's Bakery.

#### By Tim Roth

## Description

This Epicodus project extension builds on a prior, simpler project to allow for Pierre's Bakery to add Vendors to a list and create Orders accordingly. The project includes a splash page with links to Vendor List and Add Vendor pages. From the Vendor List page, clicking on a vendor name will take the user to the Vendor page with a list of that Vendor's orders. Clicking on an order will take you to a page with the order details.

## How to download to edit

* View splash page with a welcome message and links to view vendor list or add a new vendor
* Select `Vendor List` link to view the current list of vendors
* Select `Add New Vendor` link to add a vendor to the list
* Submitting new vendor redirects user to the splash page
* Selecting vendor on `Vendor List` page shows orders belonging to that vendor
* Selecting `Add Order` link adds an order for that vendor
* Submitting new order redirects to vendor page
* Selecting order on the vendor page shows user the order details

## Technologies Used

* C#
* ASP.NET&#8203; Core
* Razor
* MSTest
* Markdown
* VS Code
* Terminal
* Github

## Setup/Installation Requirements

### Prerequisites

* [.NET](https://dotnet.microsoft.com/)
* A text editor–we prefer [VS Code](https://code.visualstudio.com/)

### Installation

1. Clone the repository: `git clone https://github.com/phantomcurve/PierresUpgraded.git`
2. Navigate to the `\PierresVendorOrderTracker` directory
3. Open with your preferred text editor to view the code 

* #### Run the Program

1. Navigate to the `\PierresVendorOrderTracker` directory
2. Run `dotnet restore`
3. Run `dotnet build`
4. Start the program with `dotnet run`
5. Open http://localhost:5000/ in your preferred browser
* #### Run the Tests
1. Navigate to the `\PierresVendorOrderTracker.Tests` directory
2. Run `dotnet restore`
4. Start the tests with `dotnet test`

## Known Bugs

* None

## Contact Information

* Tim Roth [timdroth@gmail.com](mailto:timdroth@gmail.com)

## License

* MIT License 
Copyright (C) [2021] [Tim Roth]
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:
The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.