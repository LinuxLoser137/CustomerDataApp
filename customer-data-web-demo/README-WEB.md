# Northwind Customer Data App — Web Demo

This folder contains a Netlify-ready browser version of the original C# Windows Forms customer data application.

## Features

- Displays a sample customer count
- Lists company names
- Extracts and displays contact last names
- Searches and filters visible results
- Uses responsive HTML, CSS, and JavaScript
- Includes sample Northwind-style records so no local SQL Server connection is required

## Deploy to Netlify

1. Download and unzip this folder.
2. In Netlify, open your site dashboard.
3. Drag the `customer-data-web-demo` folder into **Production deploys**.
4. Wait for the deployment to show **Published**.
5. Open the production URL.

The original C# application can remain in the same GitHub repository. Add these four web files to the repository root if you want Netlify to deploy directly from GitHub:

- `index.html`
- `style.css`
- `script.js`
- `README-WEB.md`
