# UWP Inline Resource Issue

UWP documentation claims that styles can be applied to control
types as a whole, by providing a `TargetType` attribute:

- [UWP - XAML styles](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/xaml-styles)

However, that doesn't work.

So, I created this repository to provide a reproducable project,
demonstrating an issue with the UWP resource handling system.

No matter where I put my resources, their value isn't used.

#### Screenshot depicting the issue:

![UWP - unsuccessfully placing resources in XAML](https://i.stack.imgur.com/MKuxw.gif)

The `TextBlock` text should be rendered **black**, but it's always rendered **white**.

## Verification

To verify this issue, I posted a corresponding question at
[StackOverflow](https://stackoverflow.com/questions/64637614/why-are-resources-not-used-in-this-page/64639956).

The result makes me believe that either the Microsoft documentation or the
implementation of UWP is faulty.

Before I report this issue to the Microsoft UWP product team, I'll jump off by reporting
this issue to the [Microsoft UWP documentation team](https://github.com/MicrosoftDocs/windows-uwp/issues/2790).