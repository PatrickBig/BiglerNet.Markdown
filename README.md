# BiglerNet.Markdown
A markdown editing and viewing component library for Blazor.

This component relies heavily on [Markdig](https://github.com/xoofx/markdig).

# Getting started

Install `BiglerNet.Markdown` package via dotnet CLI or the NuGet package manager UI.

Add `@using BiglerNet.Markdown` to your `_Imports.razor`.

# Usage

## Viewing Markdown
If you store markdown content in a database and want to render it as HTML inside your Blazor application use the `MarkdownViewer` component.


```html
<Markdown Content="@_blogContent" />
```

```csharp
string _blogContent;

protected override OnInitializeAsync()
{
    _blogContent = await _database
        .BlogArticles.FirstOrDefaultAsync()
        .Content;
}
```


Anytime the `Content` attribute is update the component will re-render and display the generated HTML.

## Editing Markdown

TODO