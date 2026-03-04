import java.sql.*;
import java.util.Scanner;

/* 
como fazer rodar chat:
NetBeans

Clique com o botão direito no projeto → Propriedades

Vá em Bibliotecas → Adicionar JAR/Pasta

Escolha o mysql-connector-j-8.0.33.jar

Salve e execute novamente
https://dev.mysql.com/downloads/connector/j/


Miguel pra visual code:
so colaca a porra do drive dentro de uma pasta lib que ta dentro da pasto do programa, nao aceita rodar pelo defaut(treco de IDE)
é o banco ta aqui:
CREATE DATABASE cadastro_alunos;
USE cadastro_alunos;

CREATE TABLE aluno (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    curso VARCHAR(100),
    idade INT
);

*/



public class CadastroAlunos {

    // Dados de conexão com o banco
    private static final String URL = "jdbc:mysql://localhost:3306/cadastro_alunos";
    private static final String USER = "root";
    private static final String PASSWORD = ""; 

    // Método principal
    public static void main(String[] args) {
        try (Scanner sc = new Scanner(System.in)) {
            int opcao;
            
            do {
                System.out.println("\n=== MENU DE CADASTRO DE ALUNOS ===");
                System.out.println("1 - Inserir aluno");
                System.out.println("2 - Listar alunos");
                System.out.println("3 - Atualizar aluno");
                System.out.println("4 - Excluir aluno");
                System.out.println("0 - Sair");
                System.out.print("Escolha uma opção: ");
                opcao = sc.nextInt();
                sc.nextLine(); // limpar o buffer
                
                switch (opcao) {
                    case 1 -> inserirAluno(sc);
                    case 2 -> listarAlunos();
                    case 3 -> atualizarAluno(sc);
                    case 4 -> excluirAluno(sc);
                    case 0 -> System.out.println("Encerrando o programa...");
                    default -> System.out.println("Opção inválida!");
                }
                
            } while (opcao != 0);
        }
    }

    // Método para conectar ao banco
    private static Connection conectar() throws SQLException {
        try {
            Class.forName("com.mysql.cj.jdbc.Driver"); // driver correto
        } catch (ClassNotFoundException e) {
            System.out.println("Driver JDBC não encontrado!");
        }
        return DriverManager.getConnection(URL, USER, PASSWORD);
    }

    // 1. Inserir Aluno
    private static void inserirAluno(Scanner sc) {
        System.out.print("Nome: ");
        String nome = sc.nextLine();

        System.out.print("Curso: ");
        String curso = sc.nextLine();

        System.out.print("Idade: ");
        int idade = sc.nextInt();
        sc.nextLine();

        String sql = "INSERT INTO aluno (nome, curso, idade) VALUES (?, ?, ?)";

        try (Connection conn = conectar();
             PreparedStatement stmt = conn.prepareStatement(sql)) {

            stmt.setString(1, nome);
            stmt.setString(2, curso);
            stmt.setInt(3, idade);

            int linhas = stmt.executeUpdate();
            System.out.println(linhas + " aluno(s) inserido(s) com sucesso!");

        } catch (SQLException e) {
            System.out.println("Erro ao inserir aluno: " + e.getMessage());
        }
    }

    // 2. Listar Alunos
    private static void listarAlunos() {
        String sql = "SELECT * FROM aluno";

        try (Connection conn = conectar();
             PreparedStatement stmt = conn.prepareStatement(sql);
             ResultSet rs = stmt.executeQuery()) {

            System.out.println("\n--- LISTA DE ALUNOS ---");
            while (rs.next()) {
                int id = rs.getInt("id");
                String nome = rs.getString("nome");
                String curso = rs.getString("curso");
                int idade = rs.getInt("idade");

                System.out.printf("ID: %d | Nome: %s | Curso: %s | Idade: %d%n", id, nome, curso, idade);
            }

        } catch (SQLException e) {
            System.out.println("Erro ao listar alunos: " + e.getMessage());
        }
    }

    // 3. Atualizar Aluno
    private static void atualizarAluno(Scanner sc) {
        System.out.print("Digite o ID do aluno a ser atualizado: ");
        int id = sc.nextInt();
        sc.nextLine();

        System.out.print("Novo nome: ");
        String nome = sc.nextLine();

        System.out.print("Novo curso: ");
        String curso = sc.nextLine();

        System.out.print("Nova idade: ");
        int idade = sc.nextInt();
        sc.nextLine();

        String sql = "UPDATE aluno SET nome = ?, curso = ?, idade = ? WHERE id = ?";

        try (Connection conn = conectar();
             PreparedStatement stmt = conn.prepareStatement(sql)) {

            stmt.setString(1, nome);
            stmt.setString(2, curso);
            stmt.setInt(3, idade);
            stmt.setInt(4, id);

            int linhas = stmt.executeUpdate();
            if (linhas > 0) {
                System.out.println("Aluno atualizado com sucesso!");
            } else {
                System.out.println("Nenhum aluno encontrado com esse ID.");
            }

        } catch (SQLException e) {
            System.out.println("Erro ao atualizar aluno: " + e.getMessage());
        }
    }

    // 4. Excluir Aluno
    private static void excluirAluno(Scanner sc) {
        System.out.print("Digite o ID do aluno a ser excluído: ");
        int id = sc.nextInt();
        sc.nextLine();

        String sql = "DELETE FROM aluno WHERE id = ?";

        try (Connection conn = conectar();
             PreparedStatement stmt = conn.prepareStatement(sql)) {

            stmt.setInt(1, id);
            int linhas = stmt.executeUpdate();

            if (linhas > 0) {
                System.out.println("Aluno excluído com sucesso!");
            } else {
                System.out.println("Nenhum aluno encontrado com esse ID.");
            }

        } catch (SQLException e) {
            System.out.println("Erro ao excluir aluno: " + e.getMessage());
        }
    }
}