<!DOCTYPE html>
<html lang="fa">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>شایان | DevOps & CI/CD Engineer</title>
  <link rel="stylesheet" href="style.css">
</head>
<body>
  <!-- Header -->
  <header>
    <h1>شایان (S)</h1>
    <p>مهندس DevOps & CI/CD</p>
  </header>

  <!-- بخش معرفی کوتاه -->
  <section class="intro">
    <h2>سلام!</h2>
    <p>
      من شایانم. کاری که انجام می‌دم اینه که به تیم‌های نرم‌افزاری کمک می‌کنم تا کدهاشون رو به‌صورت خودکار بسازن، تست کنن و منتشر کنن.
      یعنی مثل یه خط تولید نرم‌افزار کار می‌کنم، بدون دخالت دستی.
    </p>
  </section>

  <!-- مهارت‌ها -->
  <section class="skills">
    <h2>مهارت‌ها</h2>
    <ul>
      <li>GitHub Actions</li>
      <li>CI/CD Pipelines</li>
      <li>Docker & Kubernetes</li>
      <li>HTML, CSS, JavaScript</li>
    </ul>
  </section>

  <!-- پروژه‌ها -->
  <section class="projects">
    <h2>پروژه‌ها</h2>
    <ul>
      <li><a href="https://github.com/Shastay/Stop" target="_blank">Stop Project – مدیریت و قطع CI/CD</a></li>
      <li><a href="#">Aurora Template – فروشگاه اینترنتی مینیمال</a></li>
    </ul>
  </section>

  <!-- تماس -->
  <section class="contact">
    <h2>ارتباط با من</h2>
    <p>
      <a href="https://github.com/Shastay" target="_blank">GitHub</a> |
      <a href="mailto:your@email.com">ایمیل</a> |
      <a href="#">LinkedIn</a>
    </p>
  </section>

  <!-- Footer -->
  <footer>
    <p>&copy; 2025 شایان | ساخته شده با علاقه و کد</p>
  </footer>
</body>
</html>
</html>/* تنظیمات عمومی */
body {
  font-family: 'Open Sans', sans-serif;
  direction: rtl;
  background-color: #f7f7f7;
  margin: 0;
  padding: 0;
  color: #333;
}

/* Header */
header {
  background-color: #3498db;
  color: #fff;
  padding: 2rem;
  text-align: center;
}

/* بخش‌های اصلی */
.intro, .skills, .projects, .contact {
  padding: 2rem;
  max-width: 800px;
  margin: auto;
}

/* عنوان بخش‌ها */
h2 {
  color: #3498db;
  margin-bottom: 1rem;
}

/* لیست‌ها */
ul {
  list-style: none;
  padding: 0;
}

li {
  background: #fff;
  margin: 10px 0;
  padding: 1rem;
  border-left: 5px solid #e74c3c;
  box-shadow: 0 0 5px rgba(0,0,0,0.05);
}

/* لینک‌ها */
a {
  color: #e74c3c;
  text-decoration: none;
}

a:hover {
  text-decoration: underline;
}

/* Footer */
footer {
  background-color: #3498db;
  color: #fff;
  text-align: center;
  padding: 1rem;
  margin-top: 2rem;
}