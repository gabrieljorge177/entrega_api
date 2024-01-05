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
      .get("https://localhost:7065/api/Clientes")
      .then((response) => {
        setClients(response.data);
      })
      .catch((error) => {
        console.error("Erro ao buscar a lista de clientes:", error);
      });
  }, []);

  return (
    <div>
      <h1 className={style.h1}>Lista de Clientes</h1>
      <p>
        <Link href="categoria/add-client" style={{ backgroundColor: "green" , color:'white', textDecoration:'none'}}>
          Inserir Novo Cliente
        </Link>
      </p>
      <table className="table container tabela">
        <thead>
          <tr>
            <th>Id_Cliente</th>
            <th>Acompanhantes</th>
            <th>Cpf</th>
            <th>Idade</th>
            <th>Email</th>
            <th>Nome</th>
            <th>Senha</th>
            <th>Ações</th>{" "}
            {/* Adicione uma coluna para as ações de edição e exclusão */}
          </tr>
        </thead>
        {clients.map((element) => (
          <tbody key={element.id_Cliented_Cliente}>
            <tr className={style.tabela}>
              <td>{element.id_Cliente}</td>
              <td>{element.acompanhantes}</td>
              <td>{element.cpf}</td>
              <td>{element.idade}</td>
              <td>{element.email}</td>
              <td>{element.nome}</td>
              <td>{element.senha}</td>
              <td>
                <Link
                  href={`categoria/update-client/${element.categoriaId}`}
                  className="btn btn-warning"
                >
                  Editar
                </Link>
                <Link
                  href={`categoria/delete-client/${element.categoriaId}`}
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
