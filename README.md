# DateTimeEqualityExtensions

Equality APIs for nullable DateTimes that don't suck donkey ass.

# Why

The equality semantics of nullable DateTimes in C# don't make the slightest sense. I genuinely have no idea of what they were thinking. The "right" way to deal with nullable DateTimes would be using [Nullable.Compare](https://learn.microsoft.com/en-us/dotnet/api/system.nullable.compare?view=net-8.0) instead of equality operators, but it feels quite inconvenient and unnatural.

This library provides some wrappers over Nullable.Compare that feel more natural and ergonomic.

```csharp
DateTime? dt = DateTime.Now;
DateTime? dt2 = null;
bool isGreater = dt > dt2; //false
bool isGreater2 = dt.IsGreater(dt2); //true
```
