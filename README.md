### PROJEDE KULLANILAN YAZILIM HAKKINDA
Asp.net Core 3.1 , Nginx , Postgres

### Docker İle Ayağa Kaldırmak İçin
- Sisteminizde docker yüklü olduğundan emin olunuz.
- Reponun kök klasörüne geliniz.
- Local ortam için `docker-compose up --build`
- Henüz Hazır olmayan Prod ortam için `docker-compose -f docker-compose.prod.yml up --build` komutlarını kullanarak sistemi ayağa kaldırabileceksiniz.
- http://localhost/user gibi bir mantık ile endpointlerinize erişebilirsiniz.
