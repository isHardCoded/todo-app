import React from 'react'
import '../TaskBlock/TaskBlock.scss'

const TaskBlock = () => {
	const platesLevel = ['Легко', 'Среднее', 'Сложно']
	const [items, setItems] = React.useState([])

	React.useEffect(async () => {
		const response = await fetch('http://localhost:5149/Tasks').then(response =>
			response.json()
		)
		setItems(response)
	}, [])

	return (
		<>
			{items.map(item => (
				<div className='task-block'>
					<div className='task-menu'></div>
					<ul className='task-plates'>
						{platesLevel.map((item, index) => (
							<li key={index}>{item}</li>
						))}
					</ul>
					<h4 className='task-title'>{item.title}</h4>
					<p className='task-date'>
						{item.startDate} - {item.endDate}
					</p>
					<p>{item.description}</p>
					<div className='task-line'></div>
					<div className='task-footer'>
						<div className='task-users'>1</div>
						<div className='task-chat'>1</div>
					</div>
				</div>
			))}
		</>
	)
}

export default TaskBlock
