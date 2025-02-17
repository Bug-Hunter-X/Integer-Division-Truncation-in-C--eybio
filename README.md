# Integer Division Truncation Bug in C#

This repository demonstrates a common bug in C# related to integer division. When dividing integers, the result is also an integer, and any fractional part is truncated.  This can lead to incorrect calculations if not handled properly.

The `bug.cs` file contains the buggy code, which doesn't explicitly handle potential truncation issues. The `bugSolution.cs` file provides a corrected version.