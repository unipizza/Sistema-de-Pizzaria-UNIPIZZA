-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 17-Mar-2020 às 03:27
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.2.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
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
-- Estrutura da tabela `cadgruprod`
--

CREATE TABLE `cadgruprod` (
  `cadgruprod_id` int(4) NOT NULL,
  `cadgruprod_desc` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadgruprod`
--

INSERT INTO `cadgruprod` (`cadgruprod_id`, `cadgruprod_desc`) VALUES
(1, 'PIZZAS'),
(2, 'BEBIDAS');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadmprima`
--

CREATE TABLE `cadmprima` (
  `cadmprima_idmat` int(11) NOT NULL,
  `cadmprima_desc` varchar(50) DEFAULT NULL,
  `cadmprima_status` varchar(7) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadmprima`
--

INSERT INTO `cadmprima` (`cadmprima_idmat`, `cadmprima_desc`, `cadmprima_status`) VALUES
(1, 'PRESUNTO', 'ATIVO'),
(2, 'QUEIJO', 'INATIVO');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadprod`
--

CREATE TABLE `cadprod` (
  `cadprod_idprod` int(11) NOT NULL,
  `cadprod_desc` varchar(50) DEFAULT NULL,
  `cadprod_valor` double DEFAULT NULL,
  `cadprod_idgruprod` int(11) DEFAULT NULL,
  `cadprod_status` varchar(7) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadprod`
--

INSERT INTO `cadprod` (`cadprod_idprod`, `cadprod_desc`, `cadprod_valor`, `cadprod_idgruprod`, `cadprod_status`) VALUES
(1, 'BAURU', 27.55, 1, 'ATIVO'),
(2, 'PEPSI LATA', 5, 2, 'ATIVO');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pizzaxmat`
--

CREATE TABLE `pizzaxmat` (
  `pizzaxmat_id` int(11) NOT NULL,
  `pizzaxmat_idpizza` int(11) DEFAULT NULL,
  `pizzaxmat_idmat` int(11) DEFAULT NULL,
  `pizzaxmat_qtd` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pizzaxmat`
--

INSERT INTO `pizzaxmat` (`pizzaxmat_id`, `pizzaxmat_idpizza`, `pizzaxmat_idmat`, `pizzaxmat_qtd`) VALUES
(1, 1, 1, 2),
(2, 1, 2, 3);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadgruprod`
--
ALTER TABLE `cadgruprod`
  ADD PRIMARY KEY (`cadgruprod_id`);

--
-- Índices para tabela `cadmprima`
--
ALTER TABLE `cadmprima`
  ADD PRIMARY KEY (`cadmprima_idmat`);

--
-- Índices para tabela `cadprod`
--
ALTER TABLE `cadprod`
  ADD PRIMARY KEY (`cadprod_idprod`);

--
-- Índices para tabela `pizzaxmat`
--
ALTER TABLE `pizzaxmat`
  ADD PRIMARY KEY (`pizzaxmat_id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadgruprod`
--
ALTER TABLE `cadgruprod`
  MODIFY `cadgruprod_id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `cadmprima`
--
ALTER TABLE `cadmprima`
  MODIFY `cadmprima_idmat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `cadprod`
--
ALTER TABLE `cadprod`
  MODIFY `cadprod_idprod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `pizzaxmat`
--
ALTER TABLE `pizzaxmat`
  MODIFY `pizzaxmat_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
