

export default function Food({food}: any) {
    return <div className="mb-5 ml-12">
        <h3>{food.name}</h3> ({food.stars} estrelas)
        <p>{food.description}</p>
    </div>
}