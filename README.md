# Simple Extensions ![.Net version](https://img.shields.io/badge/.Net-netstandard2.0-blue) ![Nuget](https://img.shields.io/nuget/v/Simple.Extensions?link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FSimple.Extensions) ![release workflow](https://github.com/tarek-iraqi/Simple-extensions/actions/workflows/publish.yaml/badge.svg?event=push&branch=publish)
This library provides simple and very direct extensions on some basic types of C#, although it
is simple it covers some functionality we need it all the time in many places which sometimes
casue code duplication due to its simplicity.

My intension is to collect as much as I can of these simple functions and group them in 
single basic libray to help me and others in doing their tasks in an easy way.

This library is open source and covered with unit tests to ensure its stability and to be 
confident to use it in your projects.

In this first release I covered some functions on different C# types and alot is coming
soon as well.

## What covered now:
### String Extensions:
| Method | Description |
| -- | -- |
| IsEmpty() | Return `true` if the value is empty only otherwise return `false` |
| IsNull() | Return `true` if the value is null only otherwise return `false` |
| IsWhiteSpace() | Return `true` if the value is whitespace only otherwise return `false` |
| HasValue() | Return `true` if the string has any value, it is simply a wrapper around `IsNullOrWhiteSpace` without the headache of negation |
| HasSpecialCharacters() | Return `true` if the value contains any special character otherwise return `false` |
| HasSpaces() | Return `true` if the value contains any whitespace otherwise return `false` |
| HasSpecialCharactersOrSpaces() | Return `true` if the value contains any special character or spaces otherwise return `false`  |
| HasHTMLTags() | Returns `true` if the string has HTML tags, else returns `false` |
| RemoveSpecialCharacters() | Remove any special characters in the string |
| RemoveSpaces() | Remove any spaces in the string |
| RemoveSpecialCharactersAndSpaces() | Remove any special characters or spaces in the string |
| RemoveHTMLTags() | Remove any HTML tags from the string value | 
| IsValidUrl() | Return `true` if the value is valid url otherwise return `false` |
| ExtractUrls() | Extract any valid url from the specified string |
| IsValidEmail() | Return `true` if the value is valid email otherwise return `false` |
| ExtractEmails() | Extract any valid email from the specified string |
| FromJsonTo\<T>() | Parses the text representing a single JSON value into a type|
 
### DateTime Extensions:
| Method | Description |
| -- | -- |
| ToUnixTimeStamp() | Convert any `DateTime` to unix timestamp |
| GetDateRangeTo() | Create a DateTime range between from and to DateTime |

### Long Extensions:
| Method | Description |
| -- | -- |
| FromUnixTimeStampToDateTime() | Convert unix timestamp to valid `DateTime` |

### Queryable Extensions:
| Method | Description |
| -- | -- |
| ToPaginatedListAsync\<T>() | A very simple method for pagination, it is generic which can work on your main entity or projection type. It takes page number and page size and handle the pagination calculations and returns two objects, the first one is the `IEnumerable<T>` with the specified number of records and meta data object with pagination data |
| WhereIf\<T>() | Filters a sequence of values based on a predicate with apply predicate condtion either to apply the predicate or not |
| Sort\<T>() | Sorts the elements of a sequence according to a key(s) and order direction, very useful when you have sort by feature. Just define a string with keys and sort direction like the following: `"name desc,country,age asce"` |

### Enumerable Extensions:
| Method | Description |
| -- | -- |
| WhereIf\<T>() | Filters a sequence of values based on a predicate with apply predicate condtion either to apply the predicate or not |
| HasDuplicates\<T>() | Determines whether a sequence contains any duplicate elements |
| FindDuplicates\<T>() | Returns duplicate elements in a sequence if exist |
| RemoveDuplicates\<T>() | Remove duplicate elements in a sequence if exist |
| CountDuplicates\<T>() | Get duplicate elements with number of duplication |
| TotalDuplicates\<T>() | Returns a number that represents how many elements in the specified sequence are duplicated |
| ForEach\<T>() | Performs the specified Func delegate on each element of the sequence and return new sequence |

### Enum Extensions:
| Method | Description |
| -- | -- |
| GetAttribute\<T>() | Direct way to retrieve any attribute data associated with `enum` type whether it is built in attribute as `DescriptionAttribute` or any custom attribute |

### Generic Type Extensions:
| Method | Description |
| -- | -- |
| ToJson\<T>() | Converts the provided value into a string |

You can refer to the unit tests in the repo to see some basic usage for each method.
