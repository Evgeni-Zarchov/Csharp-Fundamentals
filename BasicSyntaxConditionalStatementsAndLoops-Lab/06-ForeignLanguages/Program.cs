string country = Console.ReadLine();
string languageSpoken = "";

switch (country)
{
    case "USA":
    case "England":
        languageSpoken = "English";
        break;
    case "Spain":
    case "Argentina":
    case "Mexico":
        languageSpoken = "Spanish";
        break;
    default:
        languageSpoken = "unknown";
        break;
}

Console.WriteLine(languageSpoken);

