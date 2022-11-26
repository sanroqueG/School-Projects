-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 14-Nov-2022 às 10:14
-- Versão do servidor: 10.4.18-MariaDB
-- versão do PHP: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bancoalimentar`
--
CREATE DATABASE IF NOT EXISTS `bancoalimentar` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `bancoalimentar`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cabaz`
--

DROP TABLE IF EXISTS `cabaz`;
CREATE TABLE `cabaz` (
  `id_cabaz` int(10) NOT NULL,
  `designacao` varchar(20) NOT NULL,
  `id_recetor` int(10) DEFAULT NULL,
  `estafeta` varchar(50) DEFAULT NULL,
  `data_rececao` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cabazproduto`
--

DROP TABLE IF EXISTS `cabazproduto`;
CREATE TABLE `cabazproduto` (
  `id_cabaz` int(10) NOT NULL,
  `id_produto` int(10) NOT NULL,
  `quantidade` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoriadadores`
--

DROP TABLE IF EXISTS `categoriadadores`;
CREATE TABLE `categoriadadores` (
  `id_categoria_d` int(10) NOT NULL,
  `designacao` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `categorias`
--

DROP TABLE IF EXISTS `categorias`;
CREATE TABLE `categorias` (
  `id_categoria` int(10) NOT NULL,
  `designacao` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `dadores`
--

DROP TABLE IF EXISTS `dadores`;
CREATE TABLE `dadores` (
  `id_dador` int(10) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `id_categoria_d` int(10) DEFAULT NULL,
  `morada` varchar(50) DEFAULT NULL,
  `cod_postal` varchar(9) DEFAULT NULL,
  `NIF` varchar(9) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `entradas`
--

DROP TABLE IF EXISTS `entradas`;
CREATE TABLE `entradas` (
  `id_dador` int(10) NOT NULL,
  `data_entrada` date NOT NULL,
  `id_produto` int(10) NOT NULL,
  `quantidade` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcoes`
--

DROP TABLE IF EXISTS `funcoes`;
CREATE TABLE `funcoes` (
  `id_funcao` int(10) NOT NULL,
  `designacao` varchar(50) NOT NULL,
  `Permissao` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `locais`
--

DROP TABLE IF EXISTS `locais`;
CREATE TABLE `locais` (
  `cod_postal` varchar(9) NOT NULL,
  `localidade` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `marcas`
--

DROP TABLE IF EXISTS `marcas`;
CREATE TABLE `marcas` (
  `id_marca` int(10) NOT NULL,
  `designacao` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

DROP TABLE IF EXISTS `produto`;
CREATE TABLE `produto` (
  `id_produto` int(10) NOT NULL,
  `designacao` varchar(50) NOT NULL,
  `id_marca` int(10) NOT NULL,
  `id_categoria` int(10) NOT NULL,
  `stock` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `recetores`
--

DROP TABLE IF EXISTS `recetores`;
CREATE TABLE `recetores` (
  `id_recetor` int(10) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `turma` varchar(10) DEFAULT NULL,
  `enc_educacao` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `turmas`
--

DROP TABLE IF EXISTS `turmas`;
CREATE TABLE `turmas` (
  `turma` varchar(10) NOT NULL,
  `descricao` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `id_user` int(10) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `telemovel` varchar(9) DEFAULT NULL,
  `id_funcao` int(10) DEFAULT NULL,
  `password_user` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cabaz`
--
ALTER TABLE `cabaz`
  ADD PRIMARY KEY (`id_cabaz`),
  ADD KEY `id_recetor` (`id_recetor`);

--
-- Índices para tabela `cabazproduto`
--
ALTER TABLE `cabazproduto`
  ADD PRIMARY KEY (`id_cabaz`,`id_produto`),
  ADD KEY `id_produto` (`id_produto`);

--
-- Índices para tabela `categoriadadores`
--
ALTER TABLE `categoriadadores`
  ADD PRIMARY KEY (`id_categoria_d`);

--
-- Índices para tabela `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id_categoria`);

--
-- Índices para tabela `dadores`
--
ALTER TABLE `dadores`
  ADD PRIMARY KEY (`id_dador`),
  ADD KEY `id_categoria_d` (`id_categoria_d`),
  ADD KEY `cod_postal` (`cod_postal`);

--
-- Índices para tabela `entradas`
--
ALTER TABLE `entradas`
  ADD PRIMARY KEY (`id_dador`,`data_entrada`,`id_produto`),
  ADD KEY `id_produto` (`id_produto`);

--
-- Índices para tabela `funcoes`
--
ALTER TABLE `funcoes`
  ADD PRIMARY KEY (`id_funcao`);

--
-- Índices para tabela `locais`
--
ALTER TABLE `locais`
  ADD PRIMARY KEY (`cod_postal`);

--
-- Índices para tabela `marcas`
--
ALTER TABLE `marcas`
  ADD PRIMARY KEY (`id_marca`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`id_produto`),
  ADD KEY `id_marca` (`id_marca`),
  ADD KEY `id_categoria` (`id_categoria`);

--
-- Índices para tabela `recetores`
--
ALTER TABLE `recetores`
  ADD PRIMARY KEY (`id_recetor`),
  ADD KEY `turma` (`turma`);

--
-- Índices para tabela `turmas`
--
ALTER TABLE `turmas`
  ADD PRIMARY KEY (`turma`);

--
-- Índices para tabela `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`),
  ADD KEY `id_funcao` (`id_funcao`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cabaz`
--
ALTER TABLE `cabaz`
  MODIFY `id_cabaz` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `categoriadadores`
--
ALTER TABLE `categoriadadores`
  MODIFY `id_categoria_d` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT de tabela `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id_categoria` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de tabela `dadores`
--
ALTER TABLE `dadores`
  MODIFY `id_dador` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `funcoes`
--
ALTER TABLE `funcoes`
  MODIFY `id_funcao` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `marcas`
--
ALTER TABLE `marcas`
  MODIFY `id_marca` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `id_produto` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de tabela `recetores`
--
ALTER TABLE `recetores`
  MODIFY `id_recetor` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `users`
--
ALTER TABLE `users`
  MODIFY `id_user` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `cabaz`
--
ALTER TABLE `cabaz`
  ADD CONSTRAINT `cabaz_ibfk_1` FOREIGN KEY (`id_recetor`) REFERENCES `recetores` (`id_recetor`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Limitadores para a tabela `cabazproduto`
--
ALTER TABLE `cabazproduto`
  ADD CONSTRAINT `cabazproduto_ibfk_1` FOREIGN KEY (`id_cabaz`) REFERENCES `cabaz` (`id_cabaz`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `cabazproduto_ibfk_2` FOREIGN KEY (`id_produto`) REFERENCES `produto` (`id_produto`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Limitadores para a tabela `dadores`
--
ALTER TABLE `dadores`
  ADD CONSTRAINT `dadores_ibfk_1` FOREIGN KEY (`id_categoria_d`) REFERENCES `categoriadadores` (`id_categoria_d`),
  ADD CONSTRAINT `dadores_ibfk_2` FOREIGN KEY (`cod_postal`) REFERENCES `locais` (`cod_postal`);

--
-- Limitadores para a tabela `entradas`
--
ALTER TABLE `entradas`
  ADD CONSTRAINT `entradas_ibfk_1` FOREIGN KEY (`id_dador`) REFERENCES `dadores` (`id_dador`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `entradas_ibfk_2` FOREIGN KEY (`id_produto`) REFERENCES `produto` (`id_produto`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Limitadores para a tabela `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`id_marca`) REFERENCES `marcas` (`id_marca`),
  ADD CONSTRAINT `produto_ibfk_2` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id_categoria`);

--
-- Limitadores para a tabela `recetores`
--
ALTER TABLE `recetores`
  ADD CONSTRAINT `recetores_ibfk_1` FOREIGN KEY (`turma`) REFERENCES `turmas` (`turma`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Limitadores para a tabela `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`id_funcao`) REFERENCES `funcoes` (`id_funcao`);
COMMIT;

ALTER TABLE cabaz AUTO_INCREMENT = 1;
ALTER TABLE cabazproduto AUTO_INCREMENT = 1;
ALTER TABLE categoriadadores AUTO_INCREMENT = 1;
ALTER TABLE categorias AUTO_INCREMENT = 1;
ALTER TABLE dadores AUTO_INCREMENT = 1;
ALTER TABLE entradas AUTO_INCREMENT = 1;
ALTER TABLE funcoes AUTO_INCREMENT = 1;
ALTER TABLE locais AUTO_INCREMENT = 1;
ALTER TABLE marcas AUTO_INCREMENT = 1;
ALTER TABLE produto AUTO_INCREMENT = 1;
ALTER TABLE recetores AUTO_INCREMENT = 1; 
ALTER TABLE turmas AUTO_INCREMENT = 1;
ALTER TABLE users AUTO_INCREMENT = 1;


INSERT INTO funcoes VALUES (1, "Administrador", "Administrador");
INSERT INTO funcoes VALUES (2, "Coordenador", "Coordenador");
INSERT INTO funcoes VALUES (3, "Delegado", "Delegado");
INSERT INTO funcoes VALUES (4, "Voluntário", "Voluntário");

INSERT INTO users VALUES (1, "Administrador", "admin", "999999999", 1,  "Cidenai#540");

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
