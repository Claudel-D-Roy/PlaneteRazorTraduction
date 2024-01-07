# Planet Translation

The final web project of the third semester of my software development program, a translation from French to English has been added to the PlaneteRazor project.

The work was done in a team.

## Planets – Localization (Translation) 
This part involves making the website accessible in both languages (French and English). NASA asks you to use the localization technique with resource files to make this possible. The database has been translated for you, so you must use it.

### To Note:
1. Create a new branch from TP2 on DevOps. Attention: To make localization work, the project name must not contain hyphens (-) or spaces.
2. Retrieve the new database named Planets (.MDF and .LDF) and place it in a folder in your project (e.g., BD, DB, or Data). This database contains four tables: Planets → French, PlanetsEN → English, Characteristics → French, CharacteristicsEN → English. Make both languages work by adding a language selection component in the footer, modifying the data model, changing the database context, and modifying the service associated with managing planets.
3. For the language icon, install font-awesome (client).
4. For interfaces whose translations are not in the tables, add localization functionality using resource files.

## Planets – Ad Display View Component 
This part involves designing a single view component that will be used to display ads on the company's website pages.

Here are examples of calling the view component via tag helper:
```csharp
@*Before translation*@
<vc:pub date="2022/12/25" message="Pre-Christmas Sale! 25% discount on the latest book about the planets in the solar system. {0} days left!"></vc:pub>
@*After translation*@
<vc:pub date="2022/12/25" message="@ViewLocalizer["SaleBook"].Value"></vc:pub>
```
### To Note:
Follow the procedure seen in class to design and use a view component. This component must be called Pub. Two parameters will be needed:
- **date** → to indicate the end date of the event. This parameter should be used to calculate the number of days between today and the end date.
- **message** → To pass the message to display. Use it with `string.Format`.
