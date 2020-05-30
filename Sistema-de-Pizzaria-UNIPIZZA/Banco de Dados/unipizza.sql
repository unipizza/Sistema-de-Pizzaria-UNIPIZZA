-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11-Maio-2020 às 04:30
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.2.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `unipizza`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadcategoria`
--

CREATE TABLE `cadcategoria` (
  `id_categoria` int(11) NOT NULL,
  `descricao` varchar(50) DEFAULT NULL,
  `status` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadcategoria`
--

INSERT INTO `cadcategoria` (`id_categoria`, `descricao`, `status`) VALUES
(1, 'PIZZAS', 'A'),
(2, 'BEBIDAS', 'A'),
(3, 'SALGADOS', 'I');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadestmat`
--

CREATE TABLE `cadestmat` (
  `cod_estmat` int(11) NOT NULL,
  `id_materia` int(11) DEFAULT NULL,
  `qtde` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadestmat`
--

INSERT INTO `cadestmat` (`cod_estmat`, `id_materia`, `qtde`) VALUES
(1, 4, 60),
(2, 1, 50);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadestprod`
--

CREATE TABLE `cadestprod` (
  `id_estprod` int(11) NOT NULL,
  `id_produto` int(11) DEFAULT NULL,
  `qtde` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadestprod`
--

INSERT INTO `cadestprod` (`id_estprod`, `id_produto`, `qtde`) VALUES
(1, 1, 20);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadmateriaprima`
--

CREATE TABLE `cadmateriaprima` (
  `id_materia` int(11) NOT NULL,
  `descricao` varchar(50) DEFAULT NULL,
  `status` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadmateriaprima`
--

INSERT INTO `cadmateriaprima` (`id_materia`, `descricao`, `status`) VALUES
(1, 'PRESUNTO', 'A'),
(2, 'QUEIJO', 'A'),
(3, 'CATUPIRY', 'A'),
(4, 'CALABRESA', 'I');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadocorrencia`
--

CREATE TABLE `cadocorrencia` (
  `id_ocorrencia` int(11) NOT NULL,
  `descricao` varchar(50) DEFAULT NULL,
  `status` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadocorrencia`
--

INSERT INTO `cadocorrencia` (`id_ocorrencia`, `descricao`, `status`) VALUES
(1, 'RECLAMACAO', 'A'),
(2, 'ELOGIO', 'A'),
(3, 'SUGESTAO', 'I');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadpedido`
--

CREATE TABLE `cadpedido` (
  `id_pedido` int(11) NOT NULL,
  `data_pedido` varchar(20) DEFAULT NULL,
  `id_unidade` int(11) DEFAULT NULL,
  `val_total` double DEFAULT NULL,
  `forma_pagto` varchar(10) DEFAULT NULL,
  `delivery` char(1) DEFAULT NULL,
  `obs` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadpedido`
--

INSERT INTO `cadpedido` (`id_pedido`, `data_pedido`, `id_unidade`, `val_total`, `forma_pagto`, `delivery`, `obs`) VALUES
(1, '10/05/2020', 1, 28.5, 'CARTAO DEB', 'N', 'RETIRAR BETERRADA');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadpermissao`
--

CREATE TABLE `cadpermissao` (
  `id_permissao` int(11) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `cadpizza` int(11) DEFAULT NULL,
  `cadusuario` int(11) DEFAULT NULL,
  `cadmatprima` int(11) DEFAULT NULL,
  `cadunidade` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadpermissao`
--

INSERT INTO `cadpermissao` (`id_permissao`, `id_usuario`, `cadpizza`, `cadusuario`, `cadmatprima`, `cadunidade`) VALUES
(1, 1, 1, 0, 1, 0),
(2, 2, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadproduto`
--

CREATE TABLE `cadproduto` (
  `id_produto` int(11) NOT NULL,
  `descricao` varchar(50) DEFAULT NULL,
  `id_categoria` int(11) DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  `controla_est` char(1) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `tam_pizza` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadproduto`
--

INSERT INTO `cadproduto` (`id_produto`, `descricao`, `id_categoria`, `status`, `controla_est`, `valor`, `tam_pizza`) VALUES
(1, 'PEPSI 2L', 2, 'A', 'S', 6, NULL),
(2, 'FRANGO C CATUPIRY', 1, 'A', 'S', 22.5, 'GRANDE'),
(3, 'CATCHUP SACHE', 3, 'A', 'N', 0, NULL),
(4, 'MOSTARDA SACHE', 3, 'I', 'N', 0, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadsac`
--

CREATE TABLE `cadsac` (
  `id_sac` int(11) NOT NULL,
  `id_ocorrencia` int(11) DEFAULT NULL,
  `descricao` varchar(100) DEFAULT NULL,
  `data` varchar(10) DEFAULT NULL,
  `id_unidade` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadsac`
--

INSERT INTO `cadsac` (`id_sac`, `id_ocorrencia`, `descricao`, `data`, `id_unidade`) VALUES
(1, 2, 'PIZZA TOP DEMAIS, SELOCO', '10/05/2020', 1),
(2, 1, 'VEIO BARATA NA PIZZA', '09/05/2020', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadunidade`
--

CREATE TABLE `cadunidade` (
  `id_unidade` int(11) NOT NULL,
  `descricao` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadunidade`
--

INSERT INTO `cadunidade` (`id_unidade`, `descricao`) VALUES
(1, 'UND SOROCABA'),
(2, 'UND VOTORANTIM');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadusuario`
--

CREATE TABLE `cadusuario` (
  `id_usuario` int(11) NOT NULL,
  `username` varchar(15) DEFAULT NULL,
  `senha` varchar(10) DEFAULT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `id_unidade` int(11) DEFAULT NULL,
  `status` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadusuario`
--

INSERT INTO `cadusuario` (`id_usuario`, `username`, `senha`, `nome`, `id_unidade`, `status`) VALUES
(1, 'dolara', 'daniel', 'DANIEL OLIVEIRA', 1, 'A'),
(2, 'galopes', 'gabriela', 'GABRIELA LOPES', 2, 'I');

-- --------------------------------------------------------

--
-- Estrutura da tabela `itens_venda`
--

CREATE TABLE `itens_venda` (
  `id_itens_venda` int(11) NOT NULL,
  `id_pedido` int(11) DEFAULT NULL,
  `id_produto` int(11) DEFAULT NULL,
  `qtde` int(11) DEFAULT NULL,
  `valor` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `itens_venda`
--

INSERT INTO `itens_venda` (`id_itens_venda`, `id_pedido`, `id_produto`, `qtde`, `valor`) VALUES
(1, 1, 2, 1, 22.5),
(2, 1, 1, 1, 6);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pizza_materia`
--

CREATE TABLE `pizza_materia` (
  `id_pizza_materia` int(11) NOT NULL,
  `id_pizza` int(11) DEFAULT NULL,
  `id_materia` int(11) DEFAULT NULL,
  `qtde` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pizza_materia`
--

INSERT INTO `pizza_materia` (`id_pizza_materia`, `id_pizza`, `id_materia`, `qtde`) VALUES
(1, 2, 4, 20),
(2, 2, 2, 10);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadcategoria`
--
ALTER TABLE `cadcategoria`
  ADD PRIMARY KEY (`id_categoria`);

--
-- Índices para tabela `cadestmat`
--
ALTER TABLE `cadestmat`
  ADD PRIMARY KEY (`cod_estmat`),
  ADD KEY `id_materia` (`id_materia`);

--
-- Índices para tabela `cadestprod`
--
ALTER TABLE `cadestprod`
  ADD PRIMARY KEY (`id_estprod`),
  ADD KEY `id_produto` (`id_produto`);

--
-- Índices para tabela `cadmateriaprima`
--
ALTER TABLE `cadmateriaprima`
  ADD PRIMARY KEY (`id_materia`);

--
-- Índices para tabela `cadocorrencia`
--
ALTER TABLE `cadocorrencia`
  ADD PRIMARY KEY (`id_ocorrencia`);

--
-- Índices para tabela `cadpedido`
--
ALTER TABLE `cadpedido`
  ADD PRIMARY KEY (`id_pedido`),
  ADD KEY `id_unidade` (`id_unidade`);

--
-- Índices para tabela `cadpermissao`
--
ALTER TABLE `cadpermissao`
  ADD PRIMARY KEY (`id_permissao`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Índices para tabela `cadproduto`
--
ALTER TABLE `cadproduto`
  ADD PRIMARY KEY (`id_produto`),
  ADD KEY `id_categoria` (`id_categoria`);

--
-- Índices para tabela `cadsac`
--
ALTER TABLE `cadsac`
  ADD PRIMARY KEY (`id_sac`),
  ADD KEY `id_unidade` (`id_unidade`),
  ADD KEY `id_ocorrencia` (`id_ocorrencia`);

--
-- Índices para tabela `cadunidade`
--
ALTER TABLE `cadunidade`
  ADD PRIMARY KEY (`id_unidade`);

--
-- Índices para tabela `cadusuario`
--
ALTER TABLE `cadusuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD KEY `id_unidade` (`id_unidade`);

--
-- Índices para tabela `itens_venda`
--
ALTER TABLE `itens_venda`
  ADD PRIMARY KEY (`id_itens_venda`),
  ADD KEY `id_pedido` (`id_pedido`),
  ADD KEY `id_produto` (`id_produto`);

--
-- Índices para tabela `pizza_materia`
--
ALTER TABLE `pizza_materia`
  ADD PRIMARY KEY (`id_pizza_materia`),
  ADD KEY `id_pizza` (`id_pizza`),
  ADD KEY `id_materia` (`id_materia`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadcategoria`
--
ALTER TABLE `cadcategoria`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `cadestmat`
--
ALTER TABLE `cadestmat`
  MODIFY `cod_estmat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `cadestprod`
--
ALTER TABLE `cadestprod`
  MODIFY `id_estprod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `cadmateriaprima`
--
ALTER TABLE `cadmateriaprima`
  MODIFY `id_materia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `cadocorrencia`
--
ALTER TABLE `cadocorrencia`
  MODIFY `id_ocorrencia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `cadpedido`
--
ALTER TABLE `cadpedido`
  MODIFY `id_pedido` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `cadpermissao`
--
ALTER TABLE `cadpermissao`
  MODIFY `id_permissao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `cadproduto`
--
ALTER TABLE `cadproduto`
  MODIFY `id_produto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `cadsac`
--
ALTER TABLE `cadsac`
  MODIFY `id_sac` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `cadunidade`
--
ALTER TABLE `cadunidade`
  MODIFY `id_unidade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `cadusuario`
--
ALTER TABLE `cadusuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `itens_venda`
--
ALTER TABLE `itens_venda`
  MODIFY `id_itens_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `pizza_materia`
--
ALTER TABLE `pizza_materia`
  MODIFY `id_pizza_materia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `cadestmat`
--
ALTER TABLE `cadestmat`
  ADD CONSTRAINT `cadestmat_ibfk_1` FOREIGN KEY (`id_materia`) REFERENCES `cadmateriaprima` (`id_materia`);

--
-- Limitadores para a tabela `cadestprod`
--
ALTER TABLE `cadestprod`
  ADD CONSTRAINT `cadestprod_ibfk_1` FOREIGN KEY (`id_produto`) REFERENCES `cadproduto` (`id_produto`);

--
-- Limitadores para a tabela `cadpedido`
--
ALTER TABLE `cadpedido`
  ADD CONSTRAINT `cadpedido_ibfk_1` FOREIGN KEY (`id_unidade`) REFERENCES `cadunidade` (`id_unidade`);

--
-- Limitadores para a tabela `cadpermissao`
--
ALTER TABLE `cadpermissao`
  ADD CONSTRAINT `cadpermissao_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `cadusuario` (`id_usuario`);

--
-- Limitadores para a tabela `cadproduto`
--
ALTER TABLE `cadproduto`
  ADD CONSTRAINT `cadproduto_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `cadcategoria` (`id_categoria`);

--
-- Limitadores para a tabela `cadsac`
--
ALTER TABLE `cadsac`
  ADD CONSTRAINT `cadsac_ibfk_1` FOREIGN KEY (`id_unidade`) REFERENCES `cadunidade` (`id_unidade`),
  ADD CONSTRAINT `cadsac_ibfk_2` FOREIGN KEY (`id_ocorrencia`) REFERENCES `cadocorrencia` (`id_ocorrencia`);

--
-- Limitadores para a tabela `cadusuario`
--
ALTER TABLE `cadusuario`
  ADD CONSTRAINT `cadusuario_ibfk_1` FOREIGN KEY (`id_unidade`) REFERENCES `cadunidade` (`id_unidade`);

--
-- Limitadores para a tabela `itens_venda`
--
ALTER TABLE `itens_venda`
  ADD CONSTRAINT `itens_venda_ibfk_1` FOREIGN KEY (`id_pedido`) REFERENCES `cadpedido` (`id_pedido`),
  ADD CONSTRAINT `itens_venda_ibfk_2` FOREIGN KEY (`id_produto`) REFERENCES `cadproduto` (`id_produto`);

--
-- Limitadores para a tabela `pizza_materia`
--
ALTER TABLE `pizza_materia`
  ADD CONSTRAINT `pizza_materia_ibfk_1` FOREIGN KEY (`id_pizza`) REFERENCES `cadproduto` (`id_produto`),
  ADD CONSTRAINT `pizza_materia_ibfk_2` FOREIGN KEY (`id_materia`) REFERENCES `cadmateriaprima` (`id_materia`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
