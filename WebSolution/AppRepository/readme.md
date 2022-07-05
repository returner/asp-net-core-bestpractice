## AppRepository
일반적인 쿼리를 위한 [IRepository](./Repository/IRepository.cs)와 
읽기 전용 쿼리 [IReadRepository](./Repository/IReadRepository.cs)를 구분해서 사용.<br/>
읽기 전용 쿼리는 AsNoTracking()을 붙이고, 클래스명도 xxxReadSpec을 붙이도록 함<br/><br/>

[Specification](https://github.com/ardalis/Specification)을 이용.<br/>