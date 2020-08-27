### PROJEDE KULLANILAN YAZILIM HAKKINDA
Asp.net Core 3.1 , Nginx , Postgres

#Docker İle Ayağa Kaldırmak İçin
		1 ) Sisteminizde docker yüklü olduğundan emin olunuz.
		2 ) Reponun kök klasörüne geliniz.
		3 ) Local ortam için `docker-compose up --build`
			Henüz Hazır olmayan Prod ortam için `docker-compose -f docker-compose.prod.yml up --build` komutlarını kullanarak sistemi ayağa kaldırabileceksiniz.
		4 ) http://localhost/user gibi bir mantık ile endpointlerinize erişebilirsiniz.