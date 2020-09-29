# UlgenaAPI
A C# implementation of the ulgena.com Api V1

All methods are documented and have similar names to the ones in the docs.

Before you can use the library you will need to generate an Generic Api Key Token at  https://app.ulgena.com/

```
var ulgena = new UlgenaApi.Ulgena(apiKey);

var link = new UlgenaLink
{
	Code = UlgenaLinkRedirect.MovedRedirect,
	Strategy = UlgenaLinkStrategy.Shortest,
	Title = "Awesome Ulgena!",
	Destination = "https://www.youtube.com/watch?v=7jpbORl55x8"
};

var linkResponse = await ulgena.LinkCreate(link);
```

See sample project for more examples.

If you need other methods added submit an issue.