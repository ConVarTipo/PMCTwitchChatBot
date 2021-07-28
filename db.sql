-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Ноя 27 2020 г., 05:41
-- Версия сервера: 5.7.15
-- Версия PHP: 7.1.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `pmc`
--

-- --------------------------------------------------------

--
-- Структура таблицы `channels`
--

CREATE TABLE `channels` (
  `id` int(10) UNSIGNED NOT NULL,
  `login` varchar(64) NOT NULL,
  `password` varchar(64) NOT NULL,
  `channel` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `channels`
--

INSERT INTO `channels` (`id`, `login`, `password`, `channel`) VALUES
(1, '123', '123', '321');

-- --------------------------------------------------------

--
-- Структура таблицы `configs`
--

CREATE TABLE `configs` (
  `channel` varchar(64) NOT NULL,
  `sens` varchar(64) NOT NULL,
  `res` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `configs`
--

INSERT INTO `configs` (`channel`, `sens`, `res`) VALUES
('321', 'kek', 'kkkk');

-- --------------------------------------------------------

--
-- Структура таблицы `logs`
--

CREATE TABLE `logs` (
  `id` int(10) UNSIGNED NOT NULL,
  `channel` varchar(64) NOT NULL,
  `time` varchar(64) NOT NULL,
  `action` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `tokens`
--

CREATE TABLE `tokens` (
  `channel` varchar(64) NOT NULL,
  `token` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `channels`
--
ALTER TABLE `channels`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`),
  ADD UNIQUE KEY `login` (`login`),
  ADD UNIQUE KEY `channel` (`channel`);

--
-- Индексы таблицы `configs`
--
ALTER TABLE `configs`
  ADD UNIQUE KEY `channel` (`channel`);

--
-- Индексы таблицы `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`id`);
ALTER TABLE `logs` ADD FULLTEXT KEY `action` (`action`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `channels`
--
ALTER TABLE `channels`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT для таблицы `logs`
--
ALTER TABLE `logs`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
