using ChapterBET9.Controllers;
using ChapterBET9.Interfaces;
using ChapterBET9.Models;
using ChapterBET9.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.IdentityModel.Tokens.Jwt;
using Xunit;

namespace TesteIntegracao
{
    public class LoginControllerTeste
    {
        [Fact]
        public void LoginController_Retornar_Usuario_Invalido()
        {
            //Arrange - Preparação
            var repositoryFake = new Mock<IUsuarioRepository>();

            repositoryFake.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns((Usuario)null);

            var controller = new LoginController(repositoryFake.Object);

            LoginViewModel dadosUsuario = new LoginViewModel();
            dadosUsuario.email = "batata@email.com";
            dadosUsuario.senha = "batitinha";

            //Act - Açã0
            var resultado = controller.Login(dadosUsuario);

            //Assert - Verificação
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }


        [Fact]
        public void LoginController_Retornar_Token()
        {
            //Arrange - Preparação
            Usuario usuarioRetornado = new Usuario();
            usuarioRetornado.Email = "email@email.com";
            usuarioRetornado.Senha = "1234";
            usuarioRetornado.Tipo = "0";
            usuarioRetornado.Id = 1;

            var repositoryFake = new Mock<IUsuarioRepository>();

            repositoryFake.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(usuarioRetornado);

            LoginViewModel dadosUsuario = new LoginViewModel();
            dadosUsuario.email = "batata@email.com";
            dadosUsuario.senha = "batitinha";

            var controller = new LoginController(repositoryFake.Object);

            //Act - Ação
            OkObjectResult resultado = (OkObjectResult)controller.Login(dadosUsuario);

            string tokenString = resultado.Value.ToString().Split(' ')[3];

            var JwtHandler = new JwtSecurityTokenHandler();
            var tokenJwt = JwtHandler.ReadJwtToken(tokenString);

            //Assert - Verificação
            Assert.Equal("chapter.webapi", tokenJwt.Issuer);
        }
    }
}