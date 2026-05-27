-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-05-2026 a las 15:43:25
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ecommercetp1`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comercios`
--

CREATE TABLE `comercios` (
  `Id_Comercios` int(11) NOT NULL,
  `Nombre_Comercio` varchar(100) NOT NULL,
  `Rubro` varchar(50) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `Plan` varchar(50) DEFAULT NULL,
  `Fecha` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `comercios`
--

INSERT INTO `comercios` (`Id_Comercios`, `Nombre_Comercio`, `Rubro`, `Email`, `Telefono`, `Plan`, `Fecha`) VALUES
(1, 'LaRotiseriaComercio', 'Comida', 'larotiseria@ejemplo.com', '47889966', 'Gold', '2026-06-26'),
(2, 'Mc', 'Comida', 'mcdonalds@ejemplo.com', '55556666', 'Pro', '2026-05-26');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `envios`
--

CREATE TABLE `envios` (
  `ID_Envio` int(11) NOT NULL,
  `ID_Venta` int(11) NOT NULL,
  `Direccion` varchar(20) NOT NULL,
  `Empresa` varchar(20) NOT NULL,
  `EstadoEnvio` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `envios`
--

INSERT INTO `envios` (`ID_Envio`, `ID_Venta`, `Direccion`, `Empresa`, `EstadoEnvio`) VALUES
(2, 22, 'callefalsa123', 'Rama SRL', 'Activo'),
(3, 33, 'callefalsa1', 'Arbol SRL', 'Activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tiendas`
--

CREATE TABLE `tiendas` (
  `IdTienda` int(11) NOT NULL,
  `IdUsuarioAdm` int(11) DEFAULT NULL,
  `Nombre` varchar(20) DEFAULT NULL,
  `Url` varchar(20) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tiendas`
--

INSERT INTO `tiendas` (`IdTienda`, `IdUsuarioAdm`, `Nombre`, `Url`, `Estado`) VALUES
(1, 111, 'CristobalColon', 'www.cristobalcolon.', 1),
(2, 222, 'Isabelacatolica', 'www.isabelacatolica.', 1),
(3, 333, 'Quicksilver', 'www.quicksilver.com', 1),
(4, 444, 'Julie', 'www.julie.com.ar', 1),
(5, 555, 'Isadora', 'www.isadora.com', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(20) DEFAULT NULL,
  `Email` varchar(20) DEFAULT NULL,
  `Contrasena` varchar(20) DEFAULT NULL,
  `Tienda` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Id`, `Nombre`, `Email`, `Contrasena`, `Tienda`) VALUES
(2, 'Maria', 'maria@ejemplo.com', '1234', 'martatienda');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `ID_Venta` int(11) NOT NULL,
  `ID_Tienda` int(11) DEFAULT NULL,
  `Cliente` varchar(20) DEFAULT NULL,
  `Producto` varchar(20) DEFAULT NULL,
  `Monto` decimal(10,2) DEFAULT NULL,
  `Medio_de_Pago` varchar(20) DEFAULT NULL,
  `Estado_de_Pago` varchar(20) DEFAULT NULL,
  `Fecha` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`ID_Venta`, `ID_Tienda`, `Cliente`, `Producto`, `Monto`, `Medio_de_Pago`, `Estado_de_Pago`, `Fecha`) VALUES
(2, 2, 'Maria', 'Play', 500.00, 'Mercado Pago', 'En proceso', '2026-05-25'),
(3, 33, 'Pilar', 'Compu', 60000.00, 'Mercado Pago', 'Aceptado', '2026-05-25');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `comercios`
--
ALTER TABLE `comercios`
  ADD PRIMARY KEY (`Id_Comercios`);

--
-- Indices de la tabla `envios`
--
ALTER TABLE `envios`
  ADD PRIMARY KEY (`ID_Envio`);

--
-- Indices de la tabla `tiendas`
--
ALTER TABLE `tiendas`
  ADD PRIMARY KEY (`IdTienda`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`ID_Venta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `comercios`
--
ALTER TABLE `comercios`
  MODIFY `Id_Comercios` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `ID_Venta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
