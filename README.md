# F# Mutable Variable Scope and Function Behavior

This example demonstrates a potential issue related to mutable variables and their interaction with functions in F#.

The code showcases mutable variables `x`, `y`, and `z`. The `add` function takes two inputs and returns their sum.  The example shows that changes to mutable variables *after* a function call does not affect the function's result.  Attempting to use an unused mutable variable in the function will result in a compiler error.

The solution offers an approach to better manage mutable variables for improved clarity and predictability.