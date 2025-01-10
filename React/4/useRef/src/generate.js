export const Avatar = () => {
    return `https://i.pravatar.cc/100?img=${Math.floor(Math.random() * 70)}`
}

export const Group = () => {
  const symb = "ABCDEFGHIGKLMNOPQRSTUVWXYZ1234567890";
  let group = "";
  for(let i = 0; i < 6; i++){
      group += symb[Math.floor(Math.random() * 36)];
  }
  return group;
}

export const Email = () => {
  const symb = "abcdefghigklmnopqrstuvwxyz1234567890";
  let email = "";
  for(let i = 0; i < 6; i++){
    email += symb[Math.floor(Math.random() * 36)];
  }
  email += "@gmail.com";
  return email;
}

export const Login = () => {
  const symb = "abcdefghigklmnopqrstuvwxyzABCDEFGHIGKLMNOPQRSTUVWXYZ1234567890";
  let login = "";
  let length = Math.floor(Math.random() * (13-5)) + 7;
  for(let i = 0; i < length; i++){
    login += symb[Math.floor(Math.random() * 62)];
  }
  return login;
}

export const Phone = () => {
  const symb = "1234567890";
  let phone = "+37529";
  for(let i = 0; i < 7; i++){
    phone += symb[Math.floor(Math.random() * 10)];
  }
  return phone;
}

function randomDate(start, end) {
  return new Date(start.getTime() 
          + Math.random() * (end.getTime() - start.getTime()));
}

export const randDate = () => {
  return randomDate(new Date(2013, 0, 1), new Date());
}

export const titles = [
  "Запускаем новые GitLab Auto-scaling раннеры в Yandex Cloud",
  "Электромобили «наследили»: как производители решают проблему CO2 выбросов",
  "Поздравляем с Новым годом!",
  "Три совета для IT-стартапа. Что нужно сделать перед тем, как представить проект инвесторам",
  "Год ожиданий — и мы получили Python 3.12. Изменения, новшества и дополнения",
  "Пуш-уведомления: пользователь сам захочет оставить их включенными",
  "10 рекомендаций по VS Code для повышения продуктивности",
  "Тестируем PCIe в новом Raspberry Pi 5",
  "Назад в будущее. История создания",
  "С Днем знаний!"
]

export const names = [
    "John",
    "Jane",
    "Bob",
    "Alice",
    "Tom",
    "Александр",
    "Алексей",
    "Андрей",
    "Антон",
    "Аркадий",
    "Богдан",
    "Борис",
    "Вадим",
    "Валентин",
    "Валерий",
    "Василий",
    "Виктор",
    "Виталий",
    "Владимир",
    "Владислав",
    "Геннадий",
    "Георгий",
    "Григорий",
    "Даниил",
    "Денис",
    "Дмитрий",
    "Евгений",
    "Егор",
    "Иван",
    "Игорь",
    "Илья",
    "Константин",
    "Лев",
    "Леонид",
    "Максим",
    "Матвей",
    "Михаил",
    "Никита",
    "Николай",
    "Олег",
    "Павел",
    "Петр",
    "Роман",
    "Руслан",
    "Сергей",
    "Станислав",
    "Тимур",
    "Федор",
    "Юрий",
    "Ярослав",
    "Александра",
    "Алина",
    "Анастасия",
    "Ангелина",
    "Анна",
    "Валентина",
    "Валерия",
    "Вероника",
    "Дарья",
    "Екатерина",
    "Елена",
    "Елизавета",
    "Жанна",
    "Зоя",
    "Ирина",
    "Карина",
    "Ксения",
    "Лариса",
    "Любовь",
    "Маргарита",
    "Марина",
    "Надежда",
    "Наталья",
    "Оксана",
    "Ольга",
    "Полина",
    "Светлана",
    "Софья",
    "Татьяна",
    "Ульяна",
    "Юлия",
    "Яна",
  ];
  
  export const surnames = [
    "Smith",
    "Johnson",
    "Williams",
    "Brown",
    "Davis",
    "Иванов",
    "Петров",
    "Сидоров",
    "Кузнецов",
    "Смирнов",
    "Новиков",
    "Федоров",
    "Морозов",
    "Волков",
    "Козлов",
    "Лебедева",
    "Соколова",
    "Павлова",
    "Никитина",
    "Калинина",
    "Орлова",
    "Иванова",
    "Петрова",
    "Сидорова",
    "Кузнецова",
    "Смирнова",
  ];