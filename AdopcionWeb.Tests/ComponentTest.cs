using AdopcionWeb.Pages.DashBoard;
using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionWeb.Tests;

public class ComponentTest : TestContext
{
    [Fact]
    public void DefaulState_Header()
    {
        var renderComponent = RenderComponent<DiagramaBarras>();

        renderComponent
            .Find("h3")
            .MarkupMatches("<h3>Component</h3>");

        Assert.Empty(renderComponent.FindAll("h1"));
    }
}
