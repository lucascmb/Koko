import React from 'react';
import '../../global.css';
import './Home.css';

function Home() {

  return (
    <div className="home-container">
      <div className="row">
        <div className="inicial">
          <div className="container">
            <h1 className="top left">Encontre a pessoa certa para
            <br/>
            cuidar do seu dinheiro para você</h1>
            <h2 className="bottom right">Conectamos assessores de investimento
            <br/>
            com jovens investidores numa relação
            <br/>
            que prioriza o alinhamento de perfis
            </h2>
          </div>
        </div>
        <div className="segundo">
          <div className="container">
            <h1 className="top2 left">Por que eu, jovem de carreira acelerada,
            <br/>
            deveria olhar para a Koko?</h1>
            <h2 className="bottom2 right">
            Você tem dinheiro, mas não tem tempo?
            </h2>
            <h3 className="text right">Sabemos que você tem uma carreira de alto desempenho,
            <br/>
            e sabemos o tempo que isso consome de você.
            <br/>
            Não deixe que cuidar do seu dinheiro seja
            <br/>
            algo que consuma seu raro tempo livre.
            <br/>
            Financial Advisors estão aqui para te ajudar.</h3>
            <h2 className="bottom2 right">
            Escolha o seu momento de buscar um assessor
            </h2>
            <h3 className="text right">Você deposita seu dinheiro numa corretora e surgem
            <br/>
            dezenas de assessores te perseguindo e te enchendo de spam.
            <br/>
            Não aqui, respeitamos o seu tempo. Você entra em contato.</h3>
            <h2 className="bottom2 right">
            Busque um assessor que combine com o seu perfil
            </h2>
            <h3 className="text right">“Só porque eu empreendo, os assessores acham que eu sou
            <br/>
            alucinado por risco e precisam me enviar ações de alta volatilidade”.
            <br/>
            Aqui não vai ser assim, vamos indicar assessores que combinem com
            <br/>
            o seu objetivo de investimento a partir do nosso código de recomendação.</h3>
          </div>
        </div>
        <div className="terceiro">
          <div className="container">
            <h1 className="top2 left">Por que eu, assessor de investimento,
            <br/>
            deveria olhar para a Koko?</h1>
            <h2 className="bottom2 right">
            Saia da bolha
            </h2>
            <h3 className="text right">Entendemos que boa parcela da carteira do assessor de investimento
            <br/>
            vêm daquele tio rico, ou do colega que deu certo empreendendo.
            <br/>
            A nossa plataforma permite que a sua rede de leads cresça rapidamente.</h3>
            <h2 className="bottom2 right">
            Mostre sua diferenciação
            </h2>
            <h3 className="text right">Nossa plataforma te ajuda a montar o seu currículo
            <br/>
            e a mostrar seus diferenciais. Exibimos o que te der
            <br/>
            destaque, desde depoimentos de clientes atestando seu
            <br/>
            bom serviço à uma especialização única que você tenha.</h3>
            <h2 className="bottom2 right">
            Não tenha que pagar para aparecer no topo
            </h2>
            <h3 className="text right">Não se preocupe, nosso modelo de negócios não inclui
            <br/>
            anúncios patrocinados. O nosso código de recomendação
            <br/>
            é meritocrático: se você atende ao perfil do investidor,
            <br/>
            se você é capacitado, você vai aparecer em primeiro.
            </h3>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Home;
