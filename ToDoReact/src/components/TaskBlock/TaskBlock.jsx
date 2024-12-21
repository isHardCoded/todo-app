import React from 'react'
import '../TaskBlock/TaskBlock.scss'
import moment from 'moment'

const TaskBlock = () => {
	const [items, setItems] = React.useState([])

	const fetchData = async () => {
		const response = await fetch('http://localhost:5149/Tasks').then(response =>
			response.json()
		)
		setItems(response)
	}

	React.useEffect(() => {
		fetchData()
	}, [])

	return (
		<>
			{items.map(item => (
				<div key={item.id} className='task-block'>
					<div className='task-menu'></div>
					<ul className='task-plates'>
						<li className={item.status === 1 ? 'green' : 'red'}>
							{item.status}
						</li>
						<li className={item.status === 1 ? 'blue' : ''}>{item.tags}</li>
					</ul>
					<h4 className='task-title'>{item.title}</h4>
					<p className='task-date'>
						{moment(item.startDate).format('DD.MM.YYYY')} -{' '}
						{moment(item.endDate).format('DD.MM.YYYY')}
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
