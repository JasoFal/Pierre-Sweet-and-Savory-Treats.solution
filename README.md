# _Pierre's Sweet and Savory Treats_

#### By _**Jason Falk**_

#### _A Fidgetech independent project._

## Technologies Used

* _Html/C#/Bootstrap_
* _MySql Workbench_
* _Dotnet_

## Description

_A website to display all flavors and treats at Pierre's shop. To create, edit, add flavors/treats, and delete treats/flavors requires an account._

## Setup/Installation Requirements

1. _Open Git Bash/Open terminal of your choice navigate to directory of your choice and run this command `git clone https://github.com/JasoFal/Pierre-Sweet-and-Savory-Treats.solution.git`_
2. _Once you have cloned the project, navigate to project folder using Git Bash/ a terminal of your choice using the `cd` command and run `code .` within project folder. Alternatively you can use VSCodes (You can use any editor but these instructions are for VSCode) open folder option under the File tab to open project manually shortcut is `Ctrl + O`_

##### Installing Dependencies

3. _Navigate to the project directory, in this case **PierreTreat** using command `cd PierreTreat` in terminal._
4. _Then once in the Factory directory, run: `dotnet restore` and `dotnet build`._

##### Setting up database

5. _Within the **PierreTreat** directory create file named appsettings.json._
6. _locate file named `appsettings.example.json` and add example code to your appsettings.json adding your UserID and Password (Brackets [] not needed when adding UserId and Password). **Warning:** Do not rename the example file as it could have complications with git._
7. _Run `dotnet ef database update` to create database._

##### To run the project do the following:
1. _To run the app type `dotnet watch run` in terminal within **PierreTreat** directory._
2. _Then using a browser of your choice enter https://localhost:5001 into search bar._

## Known Bugs

* _No known bugs._

## License

_MIT License_

Copyright (c) 5/22/2024 Jason Falk

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.