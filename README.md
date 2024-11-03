# Cookie page

This is a personal project to investigate how Cookies work in .NET core razor pages.

The cookie needs to be created in the Razor page and javascript needs to read it in the front end.

## Prerequisites

[.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Project Structure

Once your project is created, you will see the following folder structure:

- **wwwroot**: Contains static files such as CSS, JavaScript, and images.
- **Pages**: Contains Razor pages (e.g., Footer > Cookie.cshtml files).

## Running the Project

1. Press Ctrl+F5 or click on the Run button to start the project.
2. A browser will open with the address `https://localhost:{PORT}`, showing you the default Razor Pages homepage.
3. Navigate the `https://localhost:{PORT}/Footer/Cookie` to view the Cookie page.
4. Use browser developer tools to confirm the cookie 'permission-cookie' is set true or false based on accepted yes or
   no.
