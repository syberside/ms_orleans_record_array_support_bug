# Minrepo to reproduce MS Orleans C# record type array related bug

## Issue description
C# `record` type (latest language version feature) could not be used as a collection generic parameter of grain method return type.

Using it produces error on client side: `Exception while trying to run client: Named type "MinRepo.Grains.Interfaces.RecordDto" is invalid: Type string "MinRepo.Grains.Interfaces.RecordDto" cannot be resolved.`

## Example
`public record RecordDto(string Value);`
`Task<RecordDto[]> SayHello(string greeting);`

See MinRepo.Grains.Interfaces\IHello.cs for details