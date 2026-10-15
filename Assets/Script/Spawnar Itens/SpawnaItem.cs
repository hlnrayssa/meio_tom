using UnityEngine;

public class SpawnaItem : MonoBehaviour
{
       public ItemPool itemPool; //pega o script do pool de itens

    public ItemDataSO[] tiposItens;//lista dos tipos de itens que podem ser instanciados

    public int quantidadeMin = 3; //quantidade minima de itens que vão ser instanciados
    public int quantidadeMax = 10; //quantidade maxima de itens que serão instanciados
    public float spawnRange = 10f; //range de spawn para os itens que serão instaciados


    void Start()
    {
        SpawnarItens();//chama a função de spawnar os itens assim que começar
    }

    // Função para spawnar os itens
    void SpawnarItens()
    {
        int quantidade = Random.Range(quantidadeMin, quantidadeMax + 1);
        /*
        - int quantidade é vai ser um número aleatório entre a quantidade minima e a quantidade maxima de itens que serão instanciados
        - int quantidade é uma variável só para guardar o número aleatório e controlar o for loop que instancia os itens
        - quantidadeMax + 1 para que o Random.Range chegue até o 10 e não pare no 9 
        */

        for (int i = 0; i < quantidade; i++)
        {
            Vector3 posicao = new Vector3(Random.Range(-spawnRange,spawnRange),transform.position.y,Random.Range(-spawnRange,spawnRange));
            //gera uma posição aleatoria, sorteando x e z dentro do range do spawner e o y é a posição do spawner, para que os itens fiquem na mesma altura do spawner
            int tipo = Random.Range(0, tiposItens.Length); 
            //sorteia um item aleatório da lista de itens que criamos no scriptable object

            //pega um item do pool ou cria um novo (se a fila estiver vazia) na posição sorteada e atribui a ele um item dos tipos de itens do SO
            GameObject novoItem = itemPool.PegarItem(posicao, Quaternion.identity);
            novoItem.GetComponent<Itens>().ConfigurarItens(tiposItens[tipo]);//configura o item do pool com os dados do tipo sorteado
        
        }
    }
}
