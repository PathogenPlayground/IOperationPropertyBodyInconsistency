This repository demonstrates (what I think is a) bug in the Roslyn `IOperation` API from the official NuGet packages for `Microsoft.CodeAnalysis.Common` and `Microsoft.CodeAnalysis.CSharp`, both version 2.8.2. It corresponds to [dotnet/roslyn#28163](https://github.com/dotnet/roslyn/issues/28163)

The issue has also been confirmed to be present in the nightly build on the Roslyn MyGet, which is 2.9.0-dev-62826-08 at the time of writing.

# Repository Overview

`OperationPropertyBodyInconsistency.html` is the output from a custom tool I have for visualizing the relationship between Roslyn `SyntaxNode`/`IOperation` instances and each line of code.

The left side shows `IOperation` instances associated with each line of code and the right side does the same for `SyntaxNode` instances. (Note that the tool doesn't try to preserve the order of children. Don't read into the order of nodes too much. It's primarly meant to show line-to-object associations.)

`OperationPropertyBodyInconsistency.cs` contains the code that I ran through the tool.

# Actual Behavior

Properties with accessor lists have associated `MethodBodyOperation`, but expression-bodied properties do not.

# Expected Behavior

All variations of the property syntax have the same `IOperation` structure.
