using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Moq;
using stock_market.Controllers;
using stock_market.DAL;
using stock_market.Model;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;
using System.Collections.Generic;

namespace enhetstesting
{
    public class PortfolioTest
    {

        //BLIR INNF�RT N�R LOGIN ER IMPLEMENTERT

        private const string _loggetInn = "loggetInn";
        private const string _ikkeLoggetInn = "";

        private readonly Mock<IPortfolioRepository> mockRep = new Mock<IPortfolioRepository>();
        private readonly Mock<ILogger<PortfolioController>> mockLog = new Mock<ILogger<PortfolioController>>();

        private readonly Mock<HttpContext> mockHttpContext = new Mock<HttpContext>();
        private readonly MockHttpSession mockSession = new MockHttpSession();

        //  [Fact]
        //  public async Task AddStockLoggetinnOK()
        //  {
        //    var mock = new Mock<PortfolioRepository>();
        //    mock.Setup(k => k.GetCurrentPortfolio());
        //    var portfolioController = new PortfolioController(mock.Object, mockLog.Object);

        //     mockSession[_loggetInn] = _loggetInn;
        //     mockHttpContext.Setup(s => s.Session).Returns(mockSession);
        //     portfolioController.ControllerContext.HttpContext = mockHttpContext.Object;

        //     var resualt = await portfolioController.AddStock("GOOGL") as OkObjectResult;

        //     Assert.Equal((int)HttpStatusCode.OK, resualt.StatusCode);
         //     Assert.Equal("User added stock", resualt.Value);
          //  }

        //    [Fact]
        //    public async Task AddstockLoggetinnIkkeOK()
        // {
        //        mockRep.Setup(k => k.AddStock("appl")).ReturnsAsync(false);
        //
        //        var stockController = new StockController(mockRep.Object, mockLog.Object);

        //        mockSession[_loggetInn] = _loggetInn;
        //        mockHttpContext.Setup(s => s.Session).Returns(mockSession);
        //       stockController.ControllerContext.HttpContext = mockHttpContext.Object;

        // Act
        //      var resultat = await stockController.AddStock("appl") as BadRequestObjectResult;

        // Assert 
        //      Assert.Equal((int)HttpStatusCode.BadRequest, resultat.StatusCode);
        //       Assert.Equal("Could not add stock", resultat.Value);
        //   }
    }
}

