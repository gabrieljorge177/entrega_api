import "bootstrap/dist/css/bootstrap.css";
import { useEffect, useState } from "react";
import axios from "axios";
import style from "../../styles/Home.module.css";
import Link from "next/link"; // Importe o Link para criar links de navegação

const Home = () => {
  const [clients, setClients] = useState([]);

  useEffect(() => {
    // Faça uma chamada GET para a API Spring Boot
    axios
      .get("https://localhost:7065/api/Passagens")
      .then((response) => {
        setClients(response.data);
      })
      .catch((error) => {
        console.error("Erro ao buscar a lista de clientes:", error);
      });
  }, []);

  return (
    <div>
      <h1 className={style.h1}>Lista de Passagens</h1>
      <p>
        <Link href="categoria/add-categoria" style={{ backgroundColor: "green" , color:'white', textDecoration:'none'}}>
          Inserir novo destino
        </Link>
      </p>
      <table className="table container tabela">
        <thead>
          <tr>
            <th>Id_Passagem</th>
            <th>Cidade</th>
            <th>Categoria</th>
            <th>Preço da passagem</th>
            <th>Data da passagem</th>
            <th>Ações</th>{" "}
            {/* Adicione uma coluna para as ações de edição e exclusão */}
          </tr>
        </thead>
        {clients.map((element) => (
          <tbody key={element.id_Passagem}>
            <tr className={style.tabela}>
              <td>{element.id_Passagem}</td>
              <td>{element.cidade}</td>
              <td>{element.categoria}</td>
              <td>{element.preco}</td>
              <td>{element.data_passagem}</td>
              <td>
                <Link
                  href={`categoria/update-categoria/${element.categoriaId}`}
                  className="btn btn-warning"
                >
                  Editar
                </Link>
                <Link
                  href={`categoria/delete-categoria/${element.categoriaId}`}
                  className="btn btn btn-danger"
                >
                  Excluir
                </Link>
              </td>
            </tr>
          </tbody>
        ))}
      </table>
    </div>
  );
};

export default Home;
